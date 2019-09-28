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
            label2.Text = ds.CalculateAverageRatingForUniversity(uni).ToString("0.0");
            this.majors = ds.getMajorsOfUniversity(this.university);
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
