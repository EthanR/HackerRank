using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStatisticsWarmUp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfElements = int.Parse(Console.ReadLine());
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(number => number).ToList();

            decimal mean = GetMean(numberOfElements, numbers);
            decimal median = GetMedian(numberOfElements, numbers);
            int mode = GetMode(numbers);
            decimal standardDeviation = GetStandardDeviation(numberOfElements, numbers, mean);

            Console.WriteLine("{0:F1}", mean);                       
            Console.WriteLine("{0:F1}", median);
            Console.WriteLine(mode);
            Console.WriteLine("{0:F1}", standardDeviation);
        }

        public static decimal GetMean(int numberOfElements, List<int> numbers)
        {
            int sum = numbers.Sum();
            return sum / (decimal)numberOfElements;
        }

        public static decimal GetMedian(int numberOfElements, List<int> numbers)
        {
            if (numberOfElements % 2 == 0)
            {
                return (numbers[(numberOfElements / 2) - 1] + numbers[(numberOfElements / 2)]) / 2M;
            }

            return decimal.Round(numbers[numberOfElements / 2], 1);
        }

        public static int GetMode(List<int> numbers)
        {
            IEnumerable<IGrouping<int, int>> groupings = numbers.GroupBy(number => number).OrderByDescending(group => group.Count());
            IEnumerable<IGrouping<int, int>> potentialModes = groupings.Where(grouping => grouping.Count() == groupings.First().Count()).OrderBy(grouping => grouping.Key);
            return potentialModes.First().Key;
        }

        public static decimal GetStandardDeviation(int numberOfElements, List<int> numbers, decimal mean)
        {
            decimal intermediarySum = numbers.Select(number => (number - mean) * (number - mean)).Sum();
            return decimal.Round((decimal)Math.Sqrt((double)(intermediarySum / numberOfElements)), 1);
        }
    }
}
