using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp15.Data;
using WindowsFormsApp15.model;

namespace WindowsFormsApp15.view
{
    public partial class UniSearchResultWindow : Form
    {
        private University university;
        private List<Major> majors;
        private DataSearch ds;
        public UniSearchResultWindow(University uni)
        {
            this.university = uni ?? throw new ArgumentNullException("UniversitySearchResultWindow was called with university null.");
            InitializeComponent();
            ds = new DataSearch();
            this.label1.Text = uni.UniversityName;
            label2.Text = ds.AverageRatingForUniversity(uni).ToString("0.0");
            AddDataToTable();
        }

        private void AddDataToTable()
        {
            ds = new DataSearch();
            this.majors = ds.GetMajorsOfUniversity(this.university);
            foreach (Major major in majors)
            {
                object[] row = new object[4];
                Tuple<double, int, int> t = ds.AverageRatingAmountCoursesAmountLecturersForMajor(major);
                row[0] = major.Name;
                if (!(t.Item1 >= 0 && t.Item1 <= 10))
                {
                    row[1] = t.Item1.ToString("0.0");
                }
                else
                {
                    row[1] = t.Item1.ToString("0.0") + "/5";
                }
                row[2] = t.Item2.ToString();
                row[3] = t.Item3.ToString();
                dataGridView1.Rows.Add(row);
            }
        }

        internal University University { get => university; set => university = value; }

       
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Major selected = majors[e.RowIndex];
            CourseSearchResultWindow csrw = new CourseSearchResultWindow(university, selected);
            csrw.Show();
            this.Close();
        }
    }
}
