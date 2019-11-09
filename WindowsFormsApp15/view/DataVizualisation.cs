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
using LiveCharts.Helpers;

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
        }

        private void InitGUI()
        {
            InitLabels();
            InitOverallChart();
            InitOrganizedChart();
            InitInterestingChart();
            InitLearnedChart();
            InitPresentedChart();
        }

        private void GetValuesFromCourses()
        {
            overallRatings = new double[5];
            organizedRatings = new double[5];
            interestingRatings = new double[5];
            presentedRatings = new double[5];
            learnedRatings = new double[5];
            foreach(Rating rating in ratings)
            {
                overallRatings[rating.OverallRating - 1]++;
                organizedRatings[rating.Organized - 1]++;
                interestingRatings[rating.Interesting - 1]++;
                presentedRatings[rating.Presentation - 1]++;
                learnedRatings[rating.Learned - 1]++;
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
            overallRatingChart.AxisX.Add(new Axis
            {
                Title = "Ratings",
                Labels = new[] {"1", "2", "3", "4", "5"}
            });
            overallRatingChart.AxisY.Add(new Axis
            {
                Title = "% of Ratings",
                LabelFormatter = value => value.ToString("N")
            });
            averageOverallRatingLabel.Text = "Average: " + ComputeStatistics.ComputeAverage(overallRatings);
            string mostCommon = "Most Common: ";
            foreach (int i in ComputeStatistics.ComputeMostCommon(overallRatings))
            {
                mostCommon += i.ToString() + " ";
            }
            mostCommonOverallRatingLabel.Text = mostCommon;
            medianOverallRatingLabel.Text = "Median: " + ComputeStatistics.ComputeMedian(overallRatings);
            varianceOverallRatingLabel.Text = "Variance: " + ComputeStatistics.ComputeVariance(overallRatings);
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
            organizedRatingChart.AxisX.Add(new Axis
            {
                Title = "Ratings",
                Labels = new[] { "1", "2", "3", "4", "5" }
            });
            organizedRatingChart.AxisY.Add(new Axis
            {
                Title = "% of Ratings",
                LabelFormatter = value => value.ToString("N")
            });
            averageOrganizedRatingLabel.Text = "Average: " + ComputeStatistics.ComputeAverage(organizedRatings);
            string mostCommon = "Most Common: ";
            foreach (int i in ComputeStatistics.ComputeMostCommon(organizedRatings))
            {
                mostCommon += i.ToString() + " ";
            }
            mostCommonOrganizedRatingLabel.Text = mostCommon;
            medianOrganizedRatingLabel.Text = "Median: " + ComputeStatistics.ComputeMedian(organizedRatings);
            varianceOrganizedRatingLabel.Text = "Variance: " + ComputeStatistics.ComputeVariance(organizedRatings);
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
            interestingRatingChart.AxisX.Add(new Axis
            {
                Title = "Ratings",
                Labels = new[] { "1", "2", "3", "4", "5" }
            });
            interestingRatingChart.AxisY.Add(new Axis
            {
                Title = "% of Ratings",
                LabelFormatter = value => value.ToString("N")
            });
            averageInterestingRatingLabel.Text = "Average: " + ComputeStatistics.ComputeAverage(interestingRatings);
            string mostCommon = "Most Common: ";
            foreach (int i in ComputeStatistics.ComputeMostCommon(interestingRatings))
            {
                mostCommon += i.ToString() + " ";
            }
            mostCommonInterestingRatingLabel.Text = mostCommon;
            medianInterestingRatingLabel.Text = "Median: " + ComputeStatistics.ComputeMedian(interestingRatings);
            varianceInterestingRatingLabel.Text = "Variance: " + ComputeStatistics.ComputeVariance(interestingRatings);
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
            presentedRatingChart.AxisX.Add(new Axis
            {
                Title = "Ratings",
                Labels = new[] { "1", "2", "3", "4", "5" }
            });
            presentedRatingChart.AxisY.Add(new Axis
            {
                Title = "% of Ratings",
                LabelFormatter = value => value.ToString("N")
            });
            averagePresentedRatingLabel.Text = "Average: " + ComputeStatistics.ComputeAverage(presentedRatings);
            string mostCommon = "Most Common: ";
            foreach (int i in ComputeStatistics.ComputeMostCommon(presentedRatings))
            {
                mostCommon += i.ToString() + " ";
            }
            mostCommonPresentedRatingLabel.Text = mostCommon;
            medianPresentedRatingLabel.Text = "Median: " + ComputeStatistics.ComputeMedian(presentedRatings);
            variancePresentedRatingLabel.Text = "Variance: " + ComputeStatistics.ComputeVariance(presentedRatings);
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
            learnedRatingChart.AxisX.Add(new Axis
            {
                Title = "Ratings",
                Labels = new[] { "1", "2", "3", "4", "5" }
            });
            learnedRatingChart.AxisY.Add(new Axis
            {
                Title = "% of Ratings",
                LabelFormatter = value => value.ToString("N")
            });
            averageLearnedRatingLabel.Text = "Average: " + ComputeStatistics.ComputeAverage(learnedRatings);
            string mostCommon = "Most Common: ";
            foreach (int i in ComputeStatistics.ComputeMostCommon(learnedRatings))
            {
                mostCommon += i.ToString() + " ";
            }
            mostCommonLearnedRatingLabel.Text = mostCommon;
            medianLearnedRatingLabel.Text = "Median: " + ComputeStatistics.ComputeMedian(learnedRatings);
            varianceLearnedRatingLabel.Text = "Variance: " + ComputeStatistics.ComputeVariance(learnedRatings);
        }
    }
}
