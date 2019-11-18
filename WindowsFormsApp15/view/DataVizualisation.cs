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
using LiveCharts.Wpf;
using LiveCharts;

namespace WindowsFormsApp15.view
{
    public partial class DataVizualisation : UserControl
    {
        private Course course;
        private List<Rating> ratings;
        private CourseViewWindow cvw;

        private double[] overallRatings;
        private double[] organizedRatings;
        private double[] interestingRatings;
        private double[] presentedRatings;
        private double[] learnedRatings;
        private List<int> contactHours;
        private List<int> selfStudyHours;
        private List<int> grades;
        private List<Tuple<int, bool>> gradesAndPassed;

        public DataVizualisation()
        {
            InitializeComponent();
        }

        public void InitData(Course course, List<Rating> ratings, CourseViewWindow cvw)
        {
            this.course = course;
            this.ratings = ratings;
            this.cvw = cvw;
            GetValuesFromCourses();
            InitGUI();
            InitGUI();
        }

        private void InitGUI()
        {
            InitLabels();
            InitOverallChart();
            InitOrganizedChart();
            InitInterestingChart();
            InitLearnedChart();
            InitPresentedChart();
            InitContactHoursChart();
            InitSelfStudyHoursChart();
            InitGradeChart();
            InitPassedChart();
        }

        private void GetValuesFromCourses()
        {
            overallRatings = new double[5];
            organizedRatings = new double[5];
            interestingRatings = new double[5];
            presentedRatings = new double[5];
            learnedRatings = new double[5];
            contactHours = new List<int>();
            selfStudyHours = new List<int>();
            grades = new List<int>();
            gradesAndPassed = new List<Tuple<int, bool>>();
            foreach (Rating rating in ratings)
            {
                overallRatings[rating.OverallRating - 1]++;
                organizedRatings[rating.Organized - 1]++;
                interestingRatings[rating.Interesting - 1]++;
                presentedRatings[rating.Presentation - 1]++;
                learnedRatings[rating.Learned - 1]++;
                contactHours.Add(rating.ContactHours);
                selfStudyHours.Add(rating.SelfStudyHours);
                grades.Add(rating.Grade);
                gradesAndPassed.Add(new Tuple<int, bool>(rating.Grade, rating.PassedFirstTime));
            }
        }

        private void InitLabels()
        {
            courseNameLabel.Text = course.Name;
            numberOfRatingsLabel.Text = "Number of Ratings: " + ratings.Count;
        }

        private void InitOverallChart()
        {
            overallRatingChart.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Overall Ratings",
                    Values = new ChartValues<double>
                    {
                        overallRatings[0]/ratings.Count,
                        overallRatings[1]/ratings.Count,
                        overallRatings[2]/ratings.Count,
                        overallRatings[3]/ratings.Count,
                        overallRatings[4]/ratings.Count
                    }
                }
            };
            overallRatingChart.AxisX = new AxesCollection{
                new Axis
                {
                    Title = "Ratings",
                    Labels = new List<string> {"1", "2", "3", "4", "5"}
                }
            };
            overallRatingChart.AxisY = new AxesCollection{
                new Axis
                {
                    Title = "% of Ratings",
                    LabelFormatter = value => (value*100).ToString("N")
                }
            };
            averageOverallRatingLabel.Text = "Average: " + ComputeStatistics.ComputeAverageGrouped(overallRatings);
            string mostCommon = "Most Common: ";
            foreach (int i in ComputeStatistics.ComputeMostCommonGrouped(overallRatings))
            {
                mostCommon += i.ToString() + " ";
            }
            mostCommonOverallRatingLabel.Text = mostCommon;
            medianOverallRatingLabel.Text = "Median: " + ComputeStatistics.ComputeMedianGrouped(overallRatings);
            varianceOverallRatingLabel.Text = "Variance: " + ComputeStatistics.ComputeVarianceGrouped(overallRatings);
        }

        private void InitOrganizedChart()
        {
            organizedRatingChart.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Organized Ratings",
                    Values = new ChartValues<double>
                    {
                        organizedRatings[0]/ratings.Count,
                        organizedRatings[1]/ratings.Count,
                        organizedRatings[2]/ratings.Count,
                        organizedRatings[3]/ratings.Count,
                        organizedRatings[4]/ratings.Count
                    }
                }
            };
            organizedRatingChart.AxisX = new AxesCollection{
                new Axis
                {
                    Title = "Ratings",
                    Labels = new[] { "1", "2", "3", "4", "5" }
                }
            };
            organizedRatingChart.AxisY = new AxesCollection{
                new Axis
                {
                    Title = "% of Ratings",
                    LabelFormatter = value => (value*100).ToString("N")
                }
            };
            averageOrganizedRatingLabel.Text = "Average: " + ComputeStatistics.ComputeAverageGrouped(organizedRatings);
            string mostCommon = "Most Common: ";
            foreach (int i in ComputeStatistics.ComputeMostCommonGrouped(organizedRatings))
            {
                mostCommon += i.ToString() + " ";
            }
            mostCommonOrganizedRatingLabel.Text = mostCommon;
            medianOrganizedRatingLabel.Text = "Median: " + ComputeStatistics.ComputeMedianGrouped(organizedRatings);
            varianceOrganizedRatingLabel.Text = "Variance: " + ComputeStatistics.ComputeVarianceGrouped(organizedRatings);
        }

        private void InitInterestingChart()
        {
            interestingRatingChart.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Interesting Ratings",
                    Values = new ChartValues<double>
                    {
                        interestingRatings[0]/ratings.Count,
                        interestingRatings[1]/ratings.Count,
                        interestingRatings[2]/ratings.Count,
                        interestingRatings[3]/ratings.Count,
                        interestingRatings[4]/ratings.Count
                    }
                }
            };
            interestingRatingChart.AxisX = new AxesCollection{
                new Axis
                {
                    Title = "Ratings",
                    Labels = new[] { "1", "2", "3", "4", "5" }
                }
            };
            interestingRatingChart.AxisY = new AxesCollection{
                new Axis
                {
                    Title = "% of Ratings",
                    LabelFormatter = value => (value*100).ToString("N")
                }
            };
            averageInterestingRatingLabel.Text = "Average: " + ComputeStatistics.ComputeAverageGrouped(interestingRatings);
            string mostCommon = "Most Common: ";
            foreach (int i in ComputeStatistics.ComputeMostCommonGrouped(interestingRatings))
            {
                mostCommon += i.ToString() + " ";
            }
            mostCommonInterestingRatingLabel.Text = mostCommon;
            medianInterestingRatingLabel.Text = "Median: " + ComputeStatistics.ComputeMedianGrouped(interestingRatings);
            varianceInterestingRatingLabel.Text = "Variance: " + ComputeStatistics.ComputeVarianceGrouped(interestingRatings);
        }

        private void InitPresentedChart()
        {
            presentedRatingChart.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "presented Ratings",
                    Values = new ChartValues<double>
                    {
                        presentedRatings[0]/ratings.Count,
                        presentedRatings[1]/ratings.Count,
                        presentedRatings[2]/ratings.Count,
                        presentedRatings[3]/ratings.Count,
                        presentedRatings[4]/ratings.Count
                    }
                }
            };
            presentedRatingChart.AxisX = new AxesCollection{
                new Axis
                {
                    Title = "Ratings",
                    Labels = new[] { "1", "2", "3", "4", "5" }
                }
            };
            presentedRatingChart.AxisY = new AxesCollection{
                new Axis
                {
                    Title = "% of Ratings",
                    LabelFormatter = value => (value*100).ToString("N")
                }
            };
            averagePresentedRatingLabel.Text = "Average: " + ComputeStatistics.ComputeAverageGrouped(presentedRatings);
            string mostCommon = "Most Common: ";
            foreach (int i in ComputeStatistics.ComputeMostCommonGrouped(presentedRatings))
            {
                mostCommon += i.ToString() + " ";
            }
            mostCommonPresentedRatingLabel.Text = mostCommon;
            medianPresentedRatingLabel.Text = "Median: " + ComputeStatistics.ComputeMedianGrouped(presentedRatings);
            variancePresentedRatingLabel.Text = "Variance: " + ComputeStatistics.ComputeVarianceGrouped(presentedRatings);
        }

        private void InitLearnedChart()
        {
            learnedRatingChart.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "learned Ratings",
                    Values = new ChartValues<double>
                    {
                        learnedRatings[0]/ratings.Count,
                        learnedRatings[1]/ratings.Count,
                        learnedRatings[2]/ratings.Count,
                        learnedRatings[3]/ratings.Count,
                        learnedRatings[4]/ratings.Count
                    }
                }
            };
            learnedRatingChart.AxisX = new AxesCollection{
                new Axis
                {
                    Title = "Ratings",
                    Labels = new[] { "1", "2", "3", "4", "5" }
                }
            };
            learnedRatingChart.AxisY = new AxesCollection{
                new Axis
                {
                    Title = "% of Ratings",
                    LabelFormatter = value => (value*100).ToString("N")
                }
            };
            averageLearnedRatingLabel.Text = "Average: " + ComputeStatistics.ComputeAverageGrouped(learnedRatings);
            string mostCommon = "Most Common: ";
            foreach (int i in ComputeStatistics.ComputeMostCommonGrouped(learnedRatings))
            {
                mostCommon += i.ToString() + " ";
            }
            mostCommonLearnedRatingLabel.Text = mostCommon;
            medianLearnedRatingLabel.Text = "Median: " + ComputeStatistics.ComputeMedianGrouped(learnedRatings);
            varianceLearnedRatingLabel.Text = "Variance: " + ComputeStatistics.ComputeVarianceGrouped(learnedRatings);
        }

        private void InitContactHoursChart()
        {
            double[] groupedHours = ComputeStatistics.GroupHours(contactHours);
            contactHourChart.Series = new SeriesCollection {
                new RowSeries
                {
                    Title = "Contact Hours",
                    Values = new ChartValues<double>
                    {
                        groupedHours[0]/ratings.Count,
                        groupedHours[1]/ratings.Count,
                        groupedHours[2]/ratings.Count,
                        groupedHours[3]/ratings.Count,
                        groupedHours[4]/ratings.Count,
                    }
                }
            };
            contactHourChart.AxisY = new AxesCollection{
                new Axis
                {
                    Title = "Hours per week",
                    Labels = new[] { "0-1", "2-3", "4-5", "6-7", "8+" }
                }
            };
            contactHourChart.AxisX = new AxesCollection{
                new Axis
                {
                    Title = "% of Ratings",
                    LabelFormatter = value => value.ToString("N")
                }
            };
            averageConactHourLabel.Text = "Average: " +
                ComputeStatistics.ComputeAverageSingles(contactHours).ToString();
            string mostCommon = "Most Common: ";
            foreach (int i in ComputeStatistics.ComputeMostCommonSingles(contactHours))
            {
                mostCommon += i.ToString() + " ";
            }
            mostCommonConactHourLabel.Text = mostCommon;
            medianConactHourLabel.Text = "Median: " +
                ComputeStatistics.ComputeMedianSingles(contactHours).ToString();
            varianceConactHourLabel.Text = "Variance: " +
                ComputeStatistics.ComputeVarianceSingles(contactHours).ToString();
        }

        private void InitSelfStudyHoursChart()
        {
            double[] groupedHours = ComputeStatistics.GroupHours(selfStudyHours);
            selfStudyHoursChart.Series = new SeriesCollection{
                new RowSeries
                {
                    Title = "selfStudy Hours",
                    Values = new ChartValues<double>
                    {
                        groupedHours[0]/ratings.Count,
                        groupedHours[1]/ratings.Count,
                        groupedHours[2]/ratings.Count,
                        groupedHours[3]/ratings.Count,
                        groupedHours[4]/ratings.Count,
                    }
                }
            };
            selfStudyHoursChart.AxisY = new AxesCollection{
                new Axis
                {
                    Title = "Hours per week",
                    Labels = new[] { "0-1", "2-3", "4-5", "6-7", "8+" }
                }
            };
            selfStudyHoursChart.AxisX = new AxesCollection{
                new Axis
                {
                    Title = "% of Ratings",
                    LabelFormatter = value => value.ToString("N")
                }
            };
            averageSelfStudyHoursLabel.Text = "Average: " +
                ComputeStatistics.ComputeAverageSingles(selfStudyHours).ToString();
            string mostCommon = "Most Common: ";
            foreach (int i in ComputeStatistics.ComputeMostCommonSingles(selfStudyHours))
            {
                mostCommon += i.ToString() + " ";
            }
            mostCommonSelfStudyHoursLabel.Text = mostCommon;
            medianSelfStudyHoursLabel.Text = "Median: " +
                ComputeStatistics.ComputeMedianSingles(selfStudyHours).ToString();
            varianceSelfStudyHoursLabel.Text = "Variance: " +
                ComputeStatistics.ComputeVarianceSingles(selfStudyHours).ToString();
        }

        private void InitGradeChart()
        {
            List<int> groupedGrades = ComputeStatistics.GroupGrades(grades);
            gradeChart.Series = new SeriesCollection{
                new ColumnSeries
                {
                    Title = "Grades",
                    Values = new ChartValues<int>
                    {
                        groupedGrades[0],
                        groupedGrades[1],
                        groupedGrades[2],
                        groupedGrades[3],
                        groupedGrades[4],
                        groupedGrades[5],
                        groupedGrades[6],
                        groupedGrades[7],
                        groupedGrades[8],
                        groupedGrades[9]
                    }
                }
            };
            gradeChart.AxisX = new AxesCollection{
                new Axis
                {
                    Title = "Grade",
                    Labels = new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" }
                }
            };
            gradeChart.AxisY = new AxesCollection{
                new Axis
                {
                    Title = "Number of Students",
                    LabelFormatter = value => value.ToString("N")
                }
            };
            averageGradeLabel.Text = "Average: " +
                ComputeStatistics.ComputeAverageSingles(grades).ToString();
            string mostCommon = "Most Common: ";
            foreach (int i in ComputeStatistics.ComputeMostCommonSingles(grades))
            {
                mostCommon += i.ToString() + " ";
            }
            mostCommonGradeLabel.Text = mostCommon;
            medianGradeLabel.Text = "Median: " +
                ComputeStatistics.ComputeMedianSingles(grades).ToString();
            varianceGradeLabel.Text = "Variance: " +
                ComputeStatistics.ComputeVarianceSingles(grades).ToString();
        }

        public void InitPassedChart()
        {
            int[] passed = ComputeStatistics.GroupPassed(gradesAndPassed);
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            passedChart.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Passed on first try",
                    Values = new ChartValues<int>{passed[0]},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Passed on second try",
                    Values = new ChartValues<int>{passed[1]},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Failed",
                    Values = new ChartValues<int>{passed[2]},
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
            };
        }

        private void DataVizualisation_Load(object sender, EventArgs e)
        {
            cvw.CloseVizualisationView();
        }

        private void openDetailedCourseButton_Click(object sender, EventArgs e)
        {
            cvw.CloseVizualisationView();
        }
    }
}
