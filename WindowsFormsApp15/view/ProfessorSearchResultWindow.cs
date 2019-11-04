using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp15.Data;
using WindowsFormsApp15.model;

namespace WindowsFormsApp15.view
{
    public partial class ProfessorSearchResultWindow : Form
    {
        private Lecturer lecturer;
        private List<Course> courses;
        private DataSearch ds;
        public ProfessorSearchResultWindow(Lecturer lecturer)
        {
            InitializeComponent();
            this.ds = new DataSearch();
            this.lecturer = lecturer;
            this.label1.Text = lecturer.TitleAndName;
            this.label2.Text = ds.AverageRatingForLecturer(lecturer).ToString("0.0");
            AddDataToTable();
        }

        private void AddDataToTable()
        {
            ds = new DataSearch();
            this.courses = ds.GetCoursesByLecturer(lecturer);
            foreach (Course course in courses)
            {
                object[] row = new object[4];
                Tuple<double, int> t = ds.AverageRatingAmountRatingsForCourse(course);
                row[0] = course.Name;
                if (!(t.Item1 >= 0 && t.Item1 <= 10))
                {
                    row[1] = t.Item1.ToString("0.0");
                }
                else
                {
                    row[1] = t.Item1.ToString("0.0") + "/5";
                }
                row[2] = t.Item2;
                row[3] = course.Major.Name;
                dataGridView1.Rows.Add(row);
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Course selected = courses[e.RowIndex];
            CourseViewWindow cvw = new CourseViewWindow(selected);
            cvw.Show();
        }
    }
}
