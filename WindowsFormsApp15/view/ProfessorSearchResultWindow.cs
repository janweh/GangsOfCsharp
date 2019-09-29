using GangsOfCsharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
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
            this.label2.Text = ds.averageRatingForLecturer(lecturer).ToString("0.0");
            addDataToTable();
        }

        private void addDataToTable()
        {
            this.courses = ds.getCoursesByLecturer(lecturer);
            DataTable dt = new DataTable();
            dt.Columns.Add("Coures");
            dt.Columns.Add("Rating");
            dt.Columns.Add("Number of Ratings");
            dt.Columns.Add("Major");
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
                row[3] = course.Major.Name;
                dt.Rows.Add(row);
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
        }
    }
}
