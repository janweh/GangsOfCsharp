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
    public partial class CourseNameSearchResultWindow : Form
    {
        private DataSearch ds;
        List<Course> courses;
        string keyword;
        public CourseNameSearchResultWindow(string keyword)
        {
            this.keyword = keyword;
            InitializeComponent();
            addDataToTable();
            this.keywordLabel.Text = "Search: '" + keyword + "'";
            this.numberResultsLabel.Text = courses.Count.ToString();
        }

        private void addDataToTable()
        {
            ds = new DataSearch();
            this.courses = ds.getCoursesByKeyword(keyword);
            DataTable dt = new DataTable();
            dt.Columns.Add("Course");
            dt.Columns.Add("Rating");
            dt.Columns.Add("Number of Ratings");
            dt.Columns.Add("Lecturer");
            foreach (Course course in courses)
            {
                DataRow row = dt.NewRow();
                Tuple<double, int> t = ds.averageRatingAmountRatingsForCourse(course);
                row[0] = course.Name;
                if (!(t.Item1 >= 0 && t.Item1 <= 10))
                {
                    row[1] = t.Item1.ToString("0.0");
                }
                else
                {
                    row[1] = t.Item1.ToString("0.0") + "/10";
                }
                row[2] = t.Item2;
                row[3] = course.Lecturer.TitleAndName;
                dt.Rows.Add(row);
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
        }
    }
}
