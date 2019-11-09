using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp15.Data;
using WindowsFormsApp15.model;

namespace WindowsFormsApp15.view
{
    public partial class CourseViewWindow : Form
    {
        private Course course;
        private List<Rating> ratings;
        private DataSearch ds;
        public CourseViewWindow(Course course)
        {
            this.course = course;
            DataSearch ds = new DataSearch();
            ratings = ds.GetRatingsByCourse(course);
            InitializeComponent();
            detailedCourseStatistics1.InitData(course, ratings, this);
            dataVizualisation1.InitData(course, ratings, this);
        }

        public void OpenVizualisationView()
        {
            detailedCourseStatistics1.Visible = false;
            dataVizualisation1.Visible = true;
        }

        public void CloseVizualisationView()
        {
            detailedCourseStatistics1.Visible = true;
            dataVizualisation1.Visible = false;
        }
    }  
}
