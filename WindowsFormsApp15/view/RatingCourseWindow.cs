using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp15.Data;
using WindowsFormsApp15.model;

namespace WindowsFormsApp15.view
{
    public partial class RatingCourseWindow : Form
    {
        Student student;
        Course course;

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
            cmbBoxSemester.DataSource = EnumTranslator.allSemester;
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
            if (!checkFields()) {return; }
            try
            {
                Rating givenRating = new Rating(student, course,
                    EnumTranslator.stringToSemester[(string)cmbBoxSemester.SelectedItem],
                    getRating(overallBoxes), (int)nupdContactHours.Value, (int)nupdSelfStudyHours.Value,
                    getRating(organizedBoxes), getRating(learnedBoxes), getRating(interestingBoxes),
                    getRating(presetedBoxes), txtBoxComments.Text);
                DataWriter dw = new DataWriter();
                dw.store(givenRating);
                this.Close();
            }
            catch (DuplicateDataException)
            {
                MessageBox.Show("You have already rated this course.", "DuplicateDataException");
            }
        }

        private bool checkFields()
        {
            if (!countRatings(overallBoxes))
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
            else if (!countRatings(organizedBoxes))
            {
                MessageBox.Show("There has to be one Rating for how well the course was organized!");
                return false;
            }
            else if (!countRatings(learnedBoxes))
            {
                MessageBox.Show("There has to be one Rating for how much you learned in this course!");
                return false;
            }
            else if (!countRatings(interestingBoxes))
            {
                MessageBox.Show("There has to be one Rating for how interesting you found the course!");
                return false;
            }
            else if (!countRatings(presetedBoxes))
            {
                MessageBox.Show("There has to be one Rating for how well the lecturer presented the subject!");
                return false;
            }
            return true;
        }

        private bool countRatings(CheckBox[] boxes)
        {
            int ratings = 0;
            foreach(CheckBox box in boxes)
            {
                if (box.Checked) ratings++;
            }
            return ratings == 1;
        }

        private int getRating(CheckBox[] boxes)
        {
            int count = 0;
            foreach(CheckBox box in boxes)
            {
                count++;
                if (box.Checked) return count;
            }
            throw new ArgumentException("One of the boxes has to be checked.");
        }
    }
}
