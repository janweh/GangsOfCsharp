using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsFormsApp15.Data;
using WindowsFormsApp15.model;

namespace WindowsFormsApp15.view
{
    public partial class RatingCourseWindow : Form
    {
        readonly Student student;
        readonly Course course;

        private CheckBox[] overallBoxes;
        private CheckBox[] organizedBoxes;
        private CheckBox[] learnedBoxes;
        private CheckBox[] interestingBoxes;
        private CheckBox[] presetedBoxes;
        public RatingCourseWindow(Student student, Course course)
        {
            this.student = student;
            this.course = course;
            InitializeComponent();
            InitBoxArrays();
            InitCourseValues();
            cmbBoxSemester.DataSource = EnumTranslator.allSemester;
        }

        private void InitCourseValues()
        {
            lblCourseName.Text = "Course Name: " + course.Name;
            lblUniversity.Text = "Offered at: " + course.University.UniversityName;
            lblBy.Text = "Held by: " + course.Lecturer.TitleAndName;
            lblSince.Text = "Offered since: " + EnumTranslator.semesterToString[course.Since];
        }

        private void InitBoxArrays()
        {


            organizedBoxes = new CheckBox[] {RatingOrganized1, RatingOrganized2, RatingOrganized3,
            RatingOrganized4, RatingOrganized5};
            learnedBoxes = new CheckBox[] {RatingLearned1, RatingLearned2, RatingLearned3,
            RatingLearned4, RatingLearned5};
            interestingBoxes = new CheckBox[] {RatingInterested1, RatingInterested2,
            RatingInterested3, RatingInterested4, RatingInterested5};
            presetedBoxes = new CheckBox[] {RatingPresent1, RatingPresent2, RatingPresent3,
            RatingPresent4, RatingPresent5};
            overallBoxes = new CheckBox[] {overallRating1, overallRating2, overallRating3,
            overallRating4, overallRating5};
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (!CheckFields()) {return; }
            try
            {
                Rating givenRating = new Rating(student, course,
                    EnumTranslator.stringToSemester[(string)cmbBoxSemester.SelectedItem],
                    GetRating(overallBoxes), (int)nupdContactHours.Value, (int)nupdSelfStudyHours.Value,
                    GetRating(organizedBoxes), GetRating(learnedBoxes), GetRating(interestingBoxes),
                    GetRating(presetedBoxes), txtBoxComments.Text, Int32.Parse(GradeTextBox.Text), 
                    GetPassedFirstTime(), DateTime.Now);
                DataWriter dw = new DataWriter();
                if (!dw.Store(givenRating))
                {
                    //if storing is unsuccesfull
                    MessageBox.Show("Saving the rating was unsuccesfull!");
                }
                else
                {
                    this.Close();
                }
            }
            catch (DuplicateDataException)
            {
                MessageBox.Show("You have already rated this course.", "DuplicateDataException");
            }
        }

        private bool CheckFields()
        {
            if (!CountRatings(overallBoxes))
            {
                MessageBox.Show("There has to be one Rating for how well the course was overall!");
                return false;
            }
            else if (cmbBoxSemester.SelectedItem == null)
            {
                MessageBox.Show("Please select the semester when you attended this course.");
                return false;
            }
            else if (nupdContactHours.Value < 0)
            {
                MessageBox.Show("The amount of contact hours has to be positive!");
                return false;
            }
            else if (nupdSelfStudyHours.Value < 0)
            {
                MessageBox.Show("The amount of self study hours has to be positive!");
                return false;
            }
            else if (!CountRatings(organizedBoxes))
            {
                MessageBox.Show("There has to be one Rating for how well the course was organized!");
                return false;
            }
            else if (!CountRatings(learnedBoxes))
            {
                MessageBox.Show("There has to be one Rating for how much you learned in this course!");
                return false;
            }
            else if (!CountRatings(interestingBoxes))
            {
                MessageBox.Show("There has to be one Rating for how interesting you found the course!");
                return false;
            }
            else if (!CountRatings(presetedBoxes))
            {
                MessageBox.Show("There has to be one Rating for how well the lecturer presented the subject!");
                return false;
            } else if (!GradeTextBoxContainsGrade())
            {
                MessageBox.Show("Please enter the grade that you received in the course!");
                return false;
            } else if(!CheckPassedFirstTime()){
                MessageBox.Show("Select either yes or no for wether you passed the course on the first try!");
                return false;
            }
            return true;
        }

        private bool CountRatings(CheckBox[] boxes)
        {
            int ratings = 0;
            foreach(CheckBox box in boxes)
            {
                if (box.Checked) ratings++;
            }
            return ratings == 1;
        }

        private int GetRating(CheckBox[] boxes)
        {
            int count = 0;
            foreach(CheckBox box in boxes)
            {
                count++;
                if (box.Checked) return count;
            }
            throw new ArgumentException("One of the boxes has to be checked.");
        }

        private bool GetPassedFirstTime()
        {
            if(yesCheckBox.Checked && !noCheckBox.Checked)
            {
                return true;
            } else 
                return false;
        }

        private void GradeTextBox_TextChanged(object sender, EventArgs e)
        {
            if(GradeTextBoxContainsGrade())
            {
                yesCheckBox.Enabled = true;
                noCheckBox.Enabled = true;
            } else
            {
                yesCheckBox.Enabled = false;
                noCheckBox.Enabled = false;
            }
        }

        private bool GradeTextBoxContainsGrade()
        {
            Regex reg = new Regex(@"[1-9]|10");
            Match match = reg.Match(GradeTextBox.Text);
            return match.Success;
        }

        private bool CheckPassedFirstTime()
        {
            return (yesCheckBox.Checked == true && noCheckBox.Checked == false) ||
                (yesCheckBox.Checked == false && noCheckBox.Checked == true);
        }

        private void YesCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            yesCheckBox.Checked = true;
            if(noCheckBox.Checked == true)
            {
                noCheckBox.Checked = false;
            }
        }

        private void NoCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            noCheckBox.Checked = true;
            if (yesCheckBox.Checked == true)
            {
                yesCheckBox.Checked = false;
            }
        }
    }
}
