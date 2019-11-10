using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp15.Data;
using WindowsFormsApp15.model;

namespace WindowsFormsApp15.view
{
    public partial class CourseNameSearchResultWindow : Form
    {
        private DataSearch ds;
        List<Course> courses;
        string keyword;
        public CourseNameSearchResultWindow(string keyword)
        {
            this.keyword = keyword;
            InitializeComponent();
            AddDataToTable();
            this.keywordLabel.Text = "Search: '" + keyword + "'";
            this.numberResultsLabel.Text = courses.Count.ToString();
        }

        private void AddDataToTable()
        {
            ds = new DataSearch();
            this.courses = ds.GetCoursesByKeyword(keyword);
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
                row[3] = course.Lecturer.TitleAndName;
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
