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
        University noSelectedUniversity;
        Major noSelectedMajor;
        Lecturer noSelectedLecturer;
        public MainWindow()
        {
            //AddTestData test = new AddTestData();
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
            if (universityComboBox.SelectedItem == noSelectedUniversity &&
                majorComboBox.SelectedItem == noSelectedMajor &&
                (professorComboBox.SelectedItem == null || professorComboBox.SelectedValue == noSelectedLecturer)
                && courseNameTextBox.Text.Equals(""))
            {
                label9.Visible = true;
            }
            //only university selected
            else if (universityComboBox.SelectedItem != noSelectedUniversity && 
                majorComboBox.SelectedItem == noSelectedMajor &&
                (professorComboBox.SelectedItem == null || professorComboBox.SelectedValue == noSelectedLecturer)
                && courseNameTextBox.Text.Equals(""))
            {
                //this is how it will work when Universities are bound to the comboBox
                //UniSearchResultWindow results = new UniSearchResultWindow(universityComboBox.SelectedItem);
                UniSearchResultWindow results = new UniSearchResultWindow(
                    (University) universityComboBox.SelectedItem);
                results.Show();
                label9.Visible = false;
            }
            //university and major selected
            else if (universityComboBox.SelectedItem != noSelectedUniversity && 
                majorComboBox.SelectedItem != noSelectedMajor&&
                (professorComboBox.SelectedItem == null || professorComboBox.SelectedValue == noSelectedLecturer) 
                && courseNameTextBox.Text.Equals(""))
            {
                CourseSearchResultWindow results = new CourseSearchResultWindow(
                    (University) universityComboBox.SelectedItem,
                    (Major) majorComboBox.SelectedItem);
                results.Show();
                label9.Visible = false;
            }
            //professor selected
            else if ((professorComboBox.SelectedItem != null || 
                professorComboBox.SelectedValue != noSelectedLecturer) &&
                courseNameTextBox.Text.Equals(""))
            {
                Object o = professorComboBox.SelectedItem;
                ProfessorSearchResultWindow results = new ProfessorSearchResultWindow(
                    (Lecturer) professorComboBox.SelectedItem);
                results.Show();
                label9.Visible = false;
            }
            //only major selected
            else if (universityComboBox.SelectedItem == noSelectedUniversity && 
                majorComboBox.SelectedItem != noSelectedMajor &&
                (professorComboBox.SelectedItem == null || professorComboBox.SelectedValue == noSelectedLecturer) 
                && courseNameTextBox.Text.Equals(""))
            {
                MajorSearchResultWindow results = new MajorSearchResultWindow(
                    (Major) majorComboBox.SelectedItem);
                results.Show();
                label9.Visible = false;
            } else if (!courseNameTextBox.Text.Equals(""))
            {
                CourseNameSearchResultWindow results = 
                    new CourseNameSearchResultWindow(courseNameTextBox.Text);
                results.Show();
                label9.Visible = false;
            }


        }

        private void UniversityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(universityComboBox.SelectedValue != noSelectedUniversity && 
                majorComboBox.SelectedValue != noSelectedMajor)
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
            if (universityComboBox.SelectedValue != noSelectedUniversity &&
                majorComboBox.SelectedValue != noSelectedMajor)
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
    }
}