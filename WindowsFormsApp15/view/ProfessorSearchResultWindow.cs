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
    public partial class ProfessorSearchResultWindow : Form
    {
        private Lecturer lecturer;
        private DataSearch ds;
        public ProfessorSearchResultWindow(Lecturer lecturer)
        {
            InitializeComponent();
            this.ds = new DataSearch();
            this.lecturer = lecturer;
            this.label1.Text = lecturer.FirstName + " " + lecturer.LastName;
            this.label2.Text = ds.CalculateAverageRatingForLecturer(lecturer).ToString("0.0");
        }
    }
}
