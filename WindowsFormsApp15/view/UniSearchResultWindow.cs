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
    public partial class UniSearchResultWindow : Form
    {
        private University university;
        private List<Major> majors;
        private DataSearch ds;
        public UniSearchResultWindow(University uni)
        {
            if (uni == null)
            {
                throw new ArgumentNullException("UniversitySearchResultWindow was called with university null.");
            }
            this.university = uni;
            InitializeComponent();
            ds = new DataSearch();
            this.label1.Text = uni.UniversityName;
            label2.Text = ds.averageRatingForUniversity(uni).ToString("0.0");
            addDataToTable();
        }

        private void addDataToTable()
        {
            this.majors = ds.getMajorsOfUniversity(this.university);
            DataTable dt = new DataTable();
            dt.Columns.Add("Major");
            dt.Columns.Add("Rating");
            dt.Columns.Add("Number of Courses");
            dt.Columns.Add("Number of Professors");
            foreach (Major major in majors)
            {
                DataRow row = dt.NewRow();
                Tuple<double, int, int> t = ds.averageRatingAmountCoursesAmountLecturersForMajor(major);
                row[0] = major.Name;
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
                dt.Rows.Add(row);
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
        }

        internal University University { get => university; set => university = value; }

        private void UniSearchResultWindow_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
