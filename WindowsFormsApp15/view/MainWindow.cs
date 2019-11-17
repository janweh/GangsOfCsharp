using System;
using System.Collections.Generic;
using System.Drawing;
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
            return (University)universityComboBox.SelectedItem;
        }
        public Major GetMajorComboBox()
        {
            return (Major)majorComboBox.SelectedItem;
        }
        public Lecturer GetProfessorComboBox()
        {
            return (Lecturer)professorComboBox.SelectedItem;
        }
        public string GetCourseNameTextField()
        {
            return courseNameTextBox.Text;
        }

        public MainWindow()
        {
            TestData test = new TestData();
            //test.DeleteAllTestDataFromTextFiles();
            //test.AddDataToTextFiles();
            //DatabaseConnection.Instance.InitDatabase();
            checker = new SearchConditionChecker(this);
            InitializeComponent();
            InitComboBoxes();
        }

        private void InitComboBoxes()
        {
            List<University> unis = ds.GetAll<University>();
            noSelectedUniversity = new University("");
            //noSelectedLecturer = new Lecturer(0, "", noSelectedUniversity, noSelectedMajor);
            unis.Insert(0, noSelectedUniversity);
            universityComboBox.DataSource = unis;
            universityComboBox.DisplayMember = "UniversityName";

            List<Major> majors = ds.GetAll<Major>();
            noSelectedMajor = new Major("", noSelectedUniversity);
            majors.Insert(0, noSelectedMajor);
            majorComboBox.DataSource = majors;
            majorComboBox.DisplayMember = "Name";

            professorComboBox.Enabled = false;
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
                    (University)universityComboBox.SelectedItem);
                results.Show();
                label9.Visible = false;
            }
            else if (checker.MajorAndUniversitySelected())
            {
                CourseSearchResultWindow results = new CourseSearchResultWindow(
                    (University)universityComboBox.SelectedItem,
                    (Major)majorComboBox.SelectedItem);
                results.Show();
                label9.Visible = false;
            }
            else if (checker.ProfessorSelected())
            {
                Lecturer l = (Lecturer)professorComboBox.SelectedItem;
                ProfessorSearchResultWindow results = new ProfessorSearchResultWindow(l);
                results.Show();
                label9.Visible = false;
            }
            else if (checker.OnlyMajorSelected())
            {
                MajorSearchResultWindow results = new MajorSearchResultWindow(
                    (Major)majorComboBox.SelectedItem);
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
            if (checker.EnableProfessor())
            {
                List<Lecturer> lecturers = ds.GetLecturersFromMajor((Major)majorComboBox.SelectedValue);
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
                List<Lecturer> lecturers = ds.GetLecturersFromMajor((Major)majorComboBox.SelectedValue);
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

        
        private void LoginButton_Click(object sender, EventArgs e)
        {

            LoginForm lf = new LoginForm();
            lf.Show();
            
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            rf.Show();

        }

        Point lastPoint;
        private void TopHeaderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void TopHeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            {
                lastPoint = new Point(e.X, e.Y);
            }
        }

        private void LogoPanel_MouseDown(object sender, MouseEventArgs e)
        {
            {
                lastPoint = new Point(e.X, e.Y);
            }
        }

        private void LogoPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void ExitBtns_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainWindow_Activated(object sender, EventArgs e)
        {
            if (LoginStatus.isLogged)
            {
                loginButton.Visible = false;
                registerButton.Visible = false;
                LogOut.Visible = true;
            }
            
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            LoginStatus.isLogged = false;
            loginButton.Visible = true;
            registerButton.Visible = true;
            LogOut.Visible = false;
            MessageBox.Show("You have logged out", "Log Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}