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
    public partial class CourseSearchResultWindow : Form
    {
        private University university;
        private Major major;
        private List<Course> courses;
        private DataSearch ds;
        public CourseSearchResultWindow(University university, Major major)
        {
            InitializeComponent();
            this.ds = new DataSearch();
            this.university = university;
            this.major = major;
            label1.Text = university.UniversityName + ": " + major.Name;
            label2.Text = ds.averageRatingForMajor(major).ToString("0.0");
            addDataToTable();

        }

        private void addDataToTable()
        {
            ds = new DataSearch();
            this.courses = ds.getCoursesByMajor(major);
            foreach (Course course in courses)
            {
                object[] row = new object[4];
                Tuple<double, int> t = ds.averageRatingAmountRatingsForCourse(course);
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
