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
            DataTable dt = new DataTable();
            dt.Columns.Add("University");
            dt.Columns.Add("Rating");
            dt.Columns.Add("Number of Courses");
            dt.Columns.Add("Number of Majors");
            dt.Columns.Add("Number of Professors");

            foreach (University university in universities)
            {
                DataRow row = dt.NewRow();
                Tuple<double, int, int, int> t = ds.averageRatingAmountCoursesMajorsProfessors(university);
                row[0] = university.UniversityName;
                if (!(t.Item1 >= 0 && t.Item1 <= 10))
                {
                    row[1] = t.Item1.ToString("0.0");
                }
                else
                {
                    row[1] = t.Item1.ToString("0.0") + "/10";
                }
                row[2] = t.Item2;
                row[3] = t.Item3;
                row[4] = t.Item4;
                dt.Rows.Add(row);
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
        }
    }
}
