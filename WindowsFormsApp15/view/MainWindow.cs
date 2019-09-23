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
            InitializeComponent();
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
            if(universityComboBox.SelectedItem == null && majorComboBox.SelectedItem == null &&
                professorComboBox.SelectedItem == null && courseNameTextBox.Text.Equals(""))
            {
                //this should be a pop up window or a red text being displayed
                label9.Visible = true;
            } else if(universityComboBox.SelectedItem != null && majorComboBox.SelectedItem == null &&
                professorComboBox.SelectedItem == null && courseNameTextBox.Text.Equals(""))
            {
                //this is how it will work when Universities are bound to the comboBox
                //UniSearchResultWindow results = new UniSearchResultWindow(universityComboBox.SelectedItem);
                University testUni = new University("Vilnius University", new List<Lecturer>(), new List<Course>());
                UniSearchResultWindow results = new UniSearchResultWindow(testUni);
                results.Show();
                label9.Visible = false;
            } else if (universityComboBox.SelectedItem != null && majorComboBox.SelectedItem != null &&
               professorComboBox.SelectedItem == null && courseNameTextBox.Text.Equals(""))
            {
                University testUni = new University("Vilnius University", new List<Lecturer>(), new List<Course>());
                Major testMajor = new Major(testUni, "Computer Sience");
                CourseSearchResultWindow results = new CourseSearchResultWindow(testUni, testMajor);
                results.Show();
                label9.Visible = false;
            } else if (professorComboBox.SelectedItem != null && courseNameTextBox.Text.Equals(""))
            {
                University testUni = new University("Vilnius University", new List<Lecturer>(), new List<Course>());
                Lecturer testLecturer = new Lecturer("Romas", "Baronas", testUni, new List<Course>());
                ProfessorSearchResultWindow results = new ProfessorSearchResultWindow(testLecturer);
                results.Show();
                label9.Visible = false;
            } 


        }
    }
}
    