using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp15.model;
using WindowsFormsApp15.Data;

namespace WindowsFormsApp15.view
{
    public partial class DetailedCourseStatistics : UserControl
    {

        private Course course;
        private List<Rating> ratings;
        private List<Comment> comments;
        private CourseViewWindow cvw;
        public DetailedCourseStatistics()
        {

            InitializeComponent();
        }

        public void InitData(Course course, List<Rating> ratings, CourseViewWindow cvw)
        {
            this.course = course;
            this.ratings = ratings;
            this.cvw = cvw;
            InitCourseProperties();
            InitComments();
            InitCommentPage(1);
        }

        private void InitCourseProperties()
        {
            lblCourseName.Text = course.Name;
            lblUniMajLect.Text = "University: " + course.University.UniversityName +
                "        Major: " + course.Major.Name +
                "        Lecturer: " + course.Lecturer.TitleAndName;
            lblSince.Text = "Since: " + EnumTranslator.semesterToString[course.Since];
            AddAverageRatings();
        }

        private void AddAverageRatings()
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
            if (count != 0)
            {
                lblOverallRating.Text = lblOverallRating.Text +
                    (overallSum / count).ToString() + "/5";
                lblContactHours.Text = lblContactHours.Text + " " +
                    (contactHoursSum / count).ToString();
                lblSelfStdyHours.Text = lblSelfStdyHours.Text + " " +
                    (selfStudySum / count).ToString();
                organizedRatingLabel.Text = (organizedSum / count).ToString() + "/5";
                learnedRatingLabel.Text = (learnedSum / count).ToString() + "/5";
                interestingRatingLabel.Text = (interestingSum / count).ToString() + "/5";
                presentedRatingLabel.Text = (presentedSum / count).ToString() + "/5";
            }

        }

        private void InitComments()
        {
            this.comments = new List<Comment>();
            foreach (Rating rating in ratings)
            {
                if (rating.Comment.Length > 0)
                {
                    comments.Add(new Comment(rating.Student.UserName, rating.Date,
                        rating.OverallRating.ToString(), rating.Comment));
                }
            }
            page1button.Visible = true;
            if (comments.Count > 4)
            {
                page2button.Visible = true;
                if (comments.Count > 8)
                {
                    page3button.Visible = true;
                    if (comments.Count > 12)
                    {
                        page4button.Visible = true;
                        if (comments.Count > 16)
                        {
                            page5button.Visible = true;
                            if (comments.Count > 20)
                            {
                                page6button.Visible = true;
                                if (comments.Count > 24)
                                {
                                    page7button.Visible = true;
                                    if (comments.Count > 28)
                                    {
                                        page8button.Visible = true;
                                        if (comments.Count > 32)
                                        {
                                            page9button.Visible = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void InitCommentPage(int pageNumber)
        {
            int positionOfFirstComment = ((pageNumber - 1) * 4) + 1;
            if (comments.Count < positionOfFirstComment
                && pageNumber != 1)
            {
                throw new ArgumentException("Too little comments. " +
                    "All the comments can fit on previous pages.");
            }
            else
            {
                if (comments.Count >= positionOfFirstComment)
                {
                    Comment display = comments[positionOfFirstComment - 1];
                    lblUsername1.Text = display.Username;
                    commentDate1.Text = display.Date;
                    commentRating1.Text = display.Rating;
                    comment1TxtBox.Text = display.Text;
                    comment1Panel.Visible = true;
                }
                else
                {
                    comment1Panel.Visible = false;
                }
                if (comments.Count >= positionOfFirstComment + 1)
                {
                    Comment display = comments[positionOfFirstComment];
                    lblUsername2.Text = display.Username;
                    commentDate2.Text = display.Date;
                    commentRating2.Text = display.Rating;
                    comment2txtBox.Text = display.Text;
                    comment2panel.Visible = true;
                }
                else
                {
                    comment2panel.Visible = false;
                }
                if (comments.Count >= positionOfFirstComment + 2)
                {
                    Comment display = comments[positionOfFirstComment + 1];
                    lblUsername3.Text = display.Username;
                    commentDate3.Text = display.Date;
                    commentRating3.Text = display.Rating;
                    comment3txtBox.Text = display.Text;
                    comment3panel.Visible = true;
                }
                else
                {
                    comment3panel.Visible = false;
                }
                if (comments.Count >= positionOfFirstComment + 3)
                {
                    Comment display = comments[positionOfFirstComment + 2];
                    lblUsername4.Text = display.Username;
                    commentDate4.Text = display.Date;
                    commentRating4.Text = display.Rating;
                    comment4txtBox.Text = display.Text;
                    comment4panel.Visible = true;
                }
                else
                {
                    comment4panel.Visible = false;
                }
            }
        }

        private void RateCourseButton_Click(object sender, EventArgs e)
        {
            RatingCourseWindow rcw = new RatingCourseWindow(LoginStatus.CurrentUser, course);
            rcw.Show();
        }

        private void CourseViewWindow_Activated(object sender, EventArgs e)
        {
            if (LoginStatus.isLogged)
            {
                rateCourseButton.Visible = true;
            }
            else
            {
                rateCourseButton.Visible = false;
            }
        }



        private void Page1button_Click_1(object sender, EventArgs e)
        {
            InitCommentPage(1);
        }

        private void Page2button_Click_1(object sender, EventArgs e)
        {
            InitCommentPage(2);
        }

        private void Page3button_Click_1(object sender, EventArgs e)
        {
            InitCommentPage(3);
        }

        private void Page4button_Click_1(object sender, EventArgs e)
        {
            InitCommentPage(4);
        }

        private void Page5button_Click_1(object sender, EventArgs e)
        {
            InitCommentPage(5);
        }

        private void Page6button_Click_1(object sender, EventArgs e)
        {
            InitCommentPage(6);
        }

        private void Page7button_Click_1(object sender, EventArgs e)
        {
            InitCommentPage(7);
        }

        private void Page8button_Click_1(object sender, EventArgs e)
        {
            InitCommentPage(8);
        }

        private void Page9button_Click_1(object sender, EventArgs e)
        {
            InitCommentPage(9);
        }

        private void DetailedStatisticsButton_Click(object sender, EventArgs e)
        {
            cvw.OpenVizualisationView();
        }

        private void rateCourseButton_Click_1(object sender, EventArgs e)
        {

        }

        private void DetailedCourseStatistics_Load(object sender, EventArgs e)
        {
            if (LoginStatus.isLogged)
            {
                rateCourseButton.Visible = true;
            }
        }

        private void DetailedCourseStatistics_Click(object sender, EventArgs e)
        {
            if (LoginStatus.isLogged)
            {
                rateCourseButton.Visible = true;
            }
            else
            {
                rateCourseButton.Visible = false;
            }
        }
    }
}
