using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15.model
{
    static class ComputeStatistics
    {
        public static double ComputeAverageGrouped(double[] xs)
        {
            double sum = 0;
            sum += xs[0] * 1;
            sum += xs[1] * 2;
            sum += xs[2] * 3;
            sum += xs[3] * 4;
            sum += xs[4] * 5;
            return sum / (xs[0] + xs[1] + xs[2] + xs[3] + xs[4]);
        }

        public static double ComputeAverageSingles(List<int> xs)
        {
            double sum = 0;
            foreach(int x in xs)
            {
                sum += x;
            }
            return sum / xs.Count;
        }

        public static List<int> ComputeMostCommonGrouped(double[] xs)
        {
            List<int> mostCommon = new List<int>();
            mostCommon.Add(1);
            foreach (int i in new int[] { 2, 3, 4, 5 })
            {
                if (xs[i - 1] > xs[mostCommon.First() - 1])
                {
                    mostCommon.Clear();
                    mostCommon.Add(i);
                }
                else if (xs[i - 1] == xs[mostCommon.First() - 1])
                {
                    mostCommon.Add(i);
                }
            }
            return mostCommon;
        }

        public static List<int> ComputeMostCommonSingles(List<int> xs)
        {
            var grouped = xs.GroupBy(x => x);
            var sorted = grouped.OrderByDescending(x => x.Count());
            List<int> mostCommon = new List<int>();

            foreach(IGrouping<int, int> s in sorted)
            {
                if(s.Count() >= sorted.First().Count())
                {
                    mostCommon.Add(s.Key);
                }
                else
                {
                    break;
                }
            }
            return mostCommon;
        }

        public static int ComputeMedianGrouped(double[] xs)
        {
            double count = 0;
            double totalSum = xs[0] + xs[1] + xs[2] + xs[3] + xs[4];
            foreach (int i in new int[] { 0, 1, 2, 3, 4 })
            {
                count += xs[i];
                if (count > totalSum / 2)
                {
                    return i + 1;
                }
            }
            return 0;
        }

        public static int ComputeMedianSingles(List<int> xs)
        {
            var ordered = from element in xs
                          orderby element ascending
                          select element;
            if(xs.Count() == 0)
            {
                return -1;
            } else if(xs.Count() % 2 == 0)
            {
                return ordered.ElementAt(xs.Count() / 2);
            } else
            {
                return ordered.ElementAt((xs.Count() - 1) / 2);
            }
        }

        public static double ComputeVarianceGrouped(double[] xs)
        {
            double average = ComputeAverageGrouped(xs);
            double variance = 0;
            double sum = xs[0] + xs[1] + xs[2] + xs[3] + xs[4];
            foreach (int i in new int[] { 1, 2, 3, 4, 5 })
            {
                double diff = Math.Abs(i - average);
                variance += diff * xs[i - 1];
            }
            return variance / sum;
        }

        public static double ComputeVarianceSingles(List<int> xs)
        {
            double average = ComputeAverageSingles(xs);
            double variance = 0;
            foreach(int i in xs)
            {
                variance += Math.Abs(i - average);
            }
            return variance / xs.Count();
        }

        public static double[] GroupHours(List<int> singleRatings)
        {
            double[] groupedRatings = new double[5];
            foreach(int i in singleRatings)
            {
                if(i < 2)
                {
                    groupedRatings[0]++;
                } else if(i < 4)
                {
                    groupedRatings[1]++;
                } else if(i < 6)
                {
                    groupedRatings[2]++;
                } else if(i < 8)
                {
                    groupedRatings[3]++;
                }
                else
                {
                    groupedRatings[4]++;
                }
            }
            return groupedRatings;
        }

        public static List<int> GroupGrades(List<int> xs)
        {
            List<int> grouped = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            foreach(int x in xs)
            {
                grouped[x - 1]++;
            }
            return grouped;
        }

        /// <summary>
        /// Groups the Grades on passing status:
        /// int[0] = Number of Students that passed on the first try,
        /// int[1] = Number of Students that passed on the second try,
        /// int[2] = Number of Students that didn't pass
        /// </summary>
        /// <param name="xs"></param>
        /// <returns></returns>
        public static int[] GroupPassed(List<Tuple<int,bool>> xs)
        {
            int[] passedGrouped = new int[3];
            foreach(Tuple<int, bool> x in xs)
            {
                if (x.Item2 == true && x.Item1 > 4)
                {
                    passedGrouped[0]++;
                } else if (x.Item2 == false && x.Item1 > 4)
                {
                    passedGrouped[1]++;
                } else if (x.Item2 == false && x.Item1 <= 4)
                {
                    passedGrouped[2]++;
                }
            }
            return passedGrouped;
        }
    }
}
