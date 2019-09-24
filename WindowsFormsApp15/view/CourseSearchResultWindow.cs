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
    public partial class CourseSearchResultWindow : Form
    {
        private University university;
        private Major major;
        private DataSearch ds;
        public CourseSearchResultWindow(University university, Major major)
        {
            InitializeComponent();
            this.ds = new DataSearch();
            this.university = university;
            this.major = major;
            label1.Text = university.Name + ": " + major.Name;
            label2.Text =  ds.CalculateAverageRatingForMajor(major).ToString("0.0");


        }

    }
}
