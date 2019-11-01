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
    public partial class MajorSearchResultWindow : Form
    {
        private Major major;
        private List<University> universities;
        private DataSearch ds;
        public MajorSearchResultWindow(Major major)
        {
            InitializeComponent();
            this.major = major;
            label1.Text = major.Name;
            addDataToTable();
        }

        private void addDataToTable()
        {
            ds = new DataSearch();
            this.universities = ds.getUniversitiesWithMajor(this.major);
            foreach (University university in universities)
            {
                object[] row = new object[5];
                Tuple<double, int, int, int> t = ds.averageRatingAmountCoursesMajorsProfessors(university);
                row[0] = University.Name;
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
                row[4] = t.Item4.ToString();
                dataGridView1.Rows.Add(row);
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            University selected = universities[e.RowIndex];
            CourseSearchResultWindow csrw = new CourseSearchResultWindow(selected, major);
            csrw.Show();
            this.Close();
        }
    }
}
