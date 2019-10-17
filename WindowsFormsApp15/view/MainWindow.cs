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
    public partial class MainWindow : Form
    {
        DataSearch ds = new DataSearch();
        SearchConditionChecker checker;
        University noSelectedUniversity;
        Major noSelectedMajor;
        Lecturer noSelectedLecturer;

        public University NoSelectedUniversity { get => noSelectedUniversity; }
        public Major NoSelectedMajor { get => noSelectedMajor; }
        public Lecturer NoSelectedLecturer { get => noSelectedLecturer; }
        public University GetUniversityComboBox()
        {
            return (University) universityComboBox.SelectedItem;
        }
        public Major GetMajorComboBox()
        {
            return (Major) majorComboBox.SelectedItem;
        }
        public Lecturer GetProfessorComboBox()
        {
            return (Lecturer) professorComboBox.SelectedItem;
        }
        public string GetCourseNameTextField()
        {
            return courseNameTextBox.Text;
        }

        public MainWindow()
        {
            TestData test = new TestData();
            //test.DeleteAllTestData();
            //test.AddData();
            checker = new SearchConditionChecker(this);
            InitializeComponent();
            initComboBoxes();
        }

        private void initComboBoxes()
        {
            List<University> unis = ds.getAll<University>();
            noSelectedUniversity = new University("");
            //noSelectedLecturer = new Lecturer(0, "", noSelectedUniversity, noSelectedMajor);
            unis.Insert(0, noSelectedUniversity);
            universityComboBox.DataSource = unis;
            universityComboBox.DisplayMember = "UniversityName";

            List<Major> majors = ds.getAll<Major>();
            noSelectedMajor = new Major("", noSelectedUniversity);
            majors.Insert(0, noSelectedMajor);
            majorComboBox.DataSource = majors;
            majorComboBox.DisplayMember = "Name";

            professorComboBox.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// backToSearchButton pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button3_Click(object sender, EventArgs e)
        {
            searchPanel.Visible = true;
            searchResultPanel.Visible = false;

        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TopHeaderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Gets called when the SearchButton is clicked.
        /// Will either open up a new window or display an error message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            if (checker.NoFieldsSelected())
            {
                label9.Visible = true;
            }
            else if (checker.OnlyUniversitySelected())
            {
                UniSearchResultWindow results = new UniSearchResultWindow(
                    (University) universityComboBox.SelectedItem);
                results.Show();
                label9.Visible = false;
            }
            else if (checker.MajorAndUniversitySelected())
            {
                CourseSearchResultWindow results = new CourseSearchResultWindow(
                    (University) universityComboBox.SelectedItem,
                    (Major) majorComboBox.SelectedItem);
                results.Show();
                label9.Visible = false;
            }
            else if (checker.ProfessorSelected())
            {
                Lecturer l= (Lecturer) professorComboBox.SelectedItem;
                ProfessorSearchResultWindow results = new ProfessorSearchResultWindow(l);
                results.Show();
                label9.Visible = false;
            }
            else if (checker.OnlyMajorSelected())
            {
                MajorSearchResultWindow results = new MajorSearchResultWindow(
                    (Major) majorComboBox.SelectedItem);
                results.Show();
                label9.Visible = false;
            }
            else if (checker.CourseNameEntered())
            {
                CourseNameSearchResultWindow results = 
                    new CourseNameSearchResultWindow(courseNameTextBox.Text);
                results.Show();
                label9.Visible = false;
            }


        }

        private void UniversityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(checker.EnableProfessor())
            {
                List<Lecturer> lecturers = ds.getLecturersFromMajor((Major) majorComboBox.SelectedValue);
                noSelectedLecturer = new Lecturer("", noSelectedUniversity, noSelectedMajor);
                lecturers.Insert(0, noSelectedLecturer);
                professorComboBox.DataSource = lecturers;
                professorComboBox.DisplayMember = "TitleAndName";
                professorComboBox.Enabled = true;
            }
            else
            {
                professorComboBox.Enabled = false;
                professorComboBox.SelectedItem = noSelectedLecturer;
            }
        }

        private void MajorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checker.EnableProfessor())
            {
                List<Lecturer> lecturers = ds.getLecturersFromMajor((Major)majorComboBox.SelectedValue);
                noSelectedLecturer = new Lecturer("", noSelectedUniversity, noSelectedMajor);
                lecturers.Insert(0, noSelectedLecturer);
                professorComboBox.DataSource = lecturers;
                professorComboBox.DisplayMember = "TitleAndName";
                professorComboBox.Enabled = true;
            }
            else
            {
                professorComboBox.Enabled = false;
                professorComboBox.SelectedItem = noSelectedLecturer;
            }
        }

        private void OverallSearchPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            SignUpWindow suw = new SignUpWindow();
            suw.Show();
        }

        private void OpenRatingLabel_Click(object sender, EventArgs e)
        {

            RatingCourseWindow rcw = new RatingCourseWindow(
                ds.getByID<Student>(Guid.Parse("313ae01f-07b8-4e5e-b113-77437e93fc79")),
                ds.getByID<Course>(Guid.Parse("cfadaa5c-7da2-402c-a7fc-2eb6be380ff2")));
            rcw.Show();
        }
    }
}