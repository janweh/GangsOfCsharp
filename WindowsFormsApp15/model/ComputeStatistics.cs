using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15.model
{
    static class ComputeStatistics
    {
        public static double ComputeAverage(double[] xs)
        {
            double sum = 0;
            sum += xs[0] * 1;
            sum += xs[1] * 2;
            sum += xs[2] * 3;
            sum += xs[3] * 4;
            sum += xs[4] * 5;
            return sum / (xs[0] + xs[1] + xs[2] + xs[3] + xs[4]);
        }

        public static List<int> ComputeMostCommon(double[] xs)
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

        public static int ComputeMedian(double[] xs)
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

        public static double ComputeVariance(double[] xs)
        {
            double average = ComputeAverage(xs);
            double variance = 0;
            double sum = xs[0] + xs[1] + xs[2] + xs[3] + xs[4];
            foreach (int i in new int[] { 1, 2, 3, 4, 5 })
            {
                double diff = Math.Abs(i - average);
                variance += diff * xs[i - 1];
            }
            return variance / sum;
        }
    }
}
