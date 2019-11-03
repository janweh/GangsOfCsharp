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
        private List<Rating> ratings;
        private List<Comment> comments;
        public CourseViewWindow(Course course)
        {
            this.course = course;
            ds = new DataSearch();
            InitializeComponent();
            InitCourseProperties();
            initComments();
            initCommentPage(1);
        }

        private void InitCourseProperties()
        {
            lblCourseName.Text = course.Name;
            lblUniMajLect.Text = "University: " + course.University.UniversityName +
                "        Major: " + course.Major.Name +
                "        Lecturer: " + course.Lecturer.TitleAndName;
            lblSince.Text = "Since: " + EnumTranslator.semesterToString[course.Since];
            ratings = ds.getRatingsByCourse(course);
            addAverageRatings();
        }

        private void addAverageRatings()
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
            if(count != 0)
            {
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

        private void initComments()
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
                if(comments.Count > 8)
                {
                    page3button.Visible = true;
                    if(comments.Count > 12)
                    {
                        page4button.Visible = true;
                        if(comments.Count > 16)
                        {
                            page5button.Visible = true;
                            if(comments.Count > 20)
                            {
                                page6button.Visible = true;
                                if(comments.Count > 24)
                                {
                                    page7button.Visible = true;
                                    if(comments.Count > 28)
                                    {
                                        page8button.Visible = true;
                                        if(comments.Count > 32)
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

        private void initCommentPage(int pageNumber)
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
                if(comments.Count >= positionOfFirstComment)
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
                if (comments.Count >= positionOfFirstComment +3)
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

        private void Page1button_Click(object sender, EventArgs e)
        {
            initCommentPage(1);
        }

        private void Page2button_Click(object sender, EventArgs e)
        {
            initCommentPage(2);
        }

        private void Page3button_Click(object sender, EventArgs e)
        {
            initCommentPage(3);
        }

        private void Page4button_Click(object sender, EventArgs e)
        {
            initCommentPage(4);
        }

        private void Page5button_Click(object sender, EventArgs e)
        {
            initCommentPage(5);
        }

        private void Page6button_Click(object sender, EventArgs e)
        {
            initCommentPage(6);
        }

        private void Page7button_Click(object sender, EventArgs e)
        {
            initCommentPage(7);
        }

        private void Page8button_Click(object sender, EventArgs e)
        {
            initCommentPage(8);
        }

        private void Page9button_Click(object sender, EventArgs e)
        {
            initCommentPage(9);
        }

        private void RateCourseButton_Click(object sender, EventArgs e)
        {
            RatingCourseWindow rcw = new RatingCourseWindow(new Student(), course);
            rcw.Show();
        }

        private void CourseViewWindow_Load(object sender, EventArgs e)
        {
            if(LoginStatus.islogged)
            {
                rateCourseButton.Visible = true;
            }
        }

        private void CourseViewWindow_Activated(object sender, EventArgs e)
        {
            if (LoginStatus.islogged)
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
