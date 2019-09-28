using GangsOfCsharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp15.model;
using WindowsFormsApp15.view;

namespace WindowsFormsApp15
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            testDataStuff();
            InitializeComponent();
        }

        private void testDataStuff()
        {
            DataSearch ds = new DataSearch();
            /*
            University testUni = new University(1, "Vilnius University");
            Major testMajor = new Major(1, "Computer Sience", testUni);
            Lecturer testLecturer = new Lecturer(1, "Prof. Dr. Max Mustermann", testUni);
            Student testStudent = new Student(1, "germanCodeMachine", "password1", "Jan Wehner",
                testUni, testMajor, "Informatics", 6);
            Course testCourse = new Course(1, "Applied Object Oriented Programming", testUni,
                testLecturer, "SS16", testMajor);
            Rating testRating = new Rating(1, testStudent, testCourse, "SS18", 8, 4, 8, 4, 5, 4, 3, 
                "great course!");
                */
            University testUni = new University(3, "Vilnius University");
            Major testMajor = new Major(1, "Computer Sience", testUni);
            //ds.store(new Lecturer(1, "Dr. Dovenschmirz", testUni, testMajor));
            //ds.store(new Lecturer(2, "XXXXXXXXXXXX", testUni, testMajor));
            //List<Course> courses = ds.getCoursesByLecturer(ds.getLecturerByID(2));
            ds.store(new University("Kaunas University"));
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

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            if (universityComboBox.SelectedItem == null && majorComboBox.SelectedItem == null &&
                professorComboBox.SelectedItem == null && courseNameTextBox.Text.Equals(""))
            {
                //this should be a pop up window or a red text being displayed
                label9.Visible = true;
            }
            else if (universityComboBox.SelectedItem != null && majorComboBox.SelectedItem == null &&
              professorComboBox.SelectedItem == null && courseNameTextBox.Text.Equals(""))
            {
                //this is how it will work when Universities are bound to the comboBox
                //UniSearchResultWindow results = new UniSearchResultWindow(universityComboBox.SelectedItem);
                University testUni = new University(1, "Vilnius University");
                UniSearchResultWindow results = new UniSearchResultWindow(testUni);
                results.Show();
                label9.Visible = false;
            }
            else if (universityComboBox.SelectedItem != null && majorComboBox.SelectedItem != null &&
             professorComboBox.SelectedItem == null && courseNameTextBox.Text.Equals(""))
            {
                University testUni = new University(1, "Vilnius University");
                Major testMajor = new Major(1, "Computer Sience", testUni);
                CourseSearchResultWindow results = new CourseSearchResultWindow(testUni, testMajor);
                results.Show();
                label9.Visible = false;
            }
            else if (professorComboBox.SelectedItem != null && courseNameTextBox.Text.Equals(""))
            {
                University testUni = new University(1, "Vilnius University");
                Major testMajor = new Major(1, "Computer Sience", testUni);
                Lecturer testLecturer = new Lecturer(1, "Prof. Dr. Romas Baronas", testUni, testMajor);
                ProfessorSearchResultWindow results = new ProfessorSearchResultWindow(testLecturer);
                results.Show();
                label9.Visible = false;
            }
            else if (universityComboBox.SelectedItem == null && majorComboBox.SelectedItem != null &&
             professorComboBox.SelectedItem == null && courseNameTextBox.Text.Equals(""))
            {
                University testUni = new University(1, "Vilnius University");
                Major testMajor = new Major(1, "Computer Sience", testUni);
                MajorSearchResultWindow results = new MajorSearchResultWindow(testMajor);
                results.Show();
                label9.Visible = false;
            }


        }
    }
}