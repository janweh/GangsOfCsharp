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
    public partial class CourseViewWindow : Form
    {
        private Course course;
        private DataSearch ds;
        public CourseViewWindow(Course course)
        {
            this.course = course;
            ds = new DataSearch();
            InitializeComponent();
            InitCourseProperties();
        }

        private void InitCourseProperties()
        {
            lblCourseName.Text = course.Name;
            lblUniMajLect.Text = "University: " + course.University.UniversityName +
                "        Major: " + course.Major.Name +
                "        Lecturer: " + course.Lecturer.TitleAndName;
            lblSince.Text = "Since: " + EnumTranslator.semesterToString[course.Since];
            List<Rating> ratings = ds.getRatingsByCourse(course);
            addAverageRatings(ratings);
        }

        private void addAverageRatings(List<Rating> ratings)
        {
            int contactHoursSum, selfStudySum, organizedSum,
            learnedSum, interestingSum, presentedSum, 
            overallSum, count;

            contactHoursSum = selfStudySum = organizedSum = 
            learnedSum = interestingSum = presentedSum = 
            overallSum = count = 0;
            foreach (Rating rating in ratings)
            {
                count++;
                contactHoursSum += rating.ContactHours;
                selfStudySum += rating.SelfStudyHours;
                organizedSum += rating.Organized;
                learnedSum += rating.Learned;
                interestingSum += rating.Interesting;
                presentedSum += rating.Presentation;
                overallSum += rating.OverallRating;
            }
            lblOverallRating.Text = "Overall Rating: " + 
                (overallSum / count).ToString() + "/5";
            lblContactHours.Text.Concat(" " + 
                (contactHoursSum / count).ToString());
            lblSelfStdyHours.Text.Concat(" " +
                (selfStudySum / count).ToString());
            organizedRatingLabel.Text = (organizedSum / count).ToString() + "/5";
            learnedRatingLabel.Text = (learnedSum / count).ToString() + "/5";
            interestingRatingLabel.Text = (interestingSum / count).ToString() + "/5";
            presentedRatingLabel.Text = (presentedSum / count).ToString() + "/5";

        }
    }
}
