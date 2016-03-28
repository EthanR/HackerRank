using System;
using System.Collections.Generic;

namespace MultiplesOfThreeAndFive
{
    public class Program
    {
        static void Main(String[] args)
        {
            List<long> sums = new List<long>();
            int numberOfTestCases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberOfTestCases; i++)
            {
                long testCase = Convert.ToInt64(Console.ReadLine());
                sums.Add(GetSum(testCase));
            }

            foreach (long sum in sums)
            {
                Console.WriteLine(sum);
            }
        }

        public static long GetSum(long upperBound)
        {
            long numberOfMultiplesOfThree = (upperBound - 1) / 3;
            long numberOfMultiplesOfFive = (upperBound - 1) / 5;
            long numberOfMultiplesOfFifteen = (upperBound - 1) / 15;

            long multiplesOfThree = 3 * (numberOfMultiplesOfThree * (numberOfMultiplesOfThree + 1) / 2);
            long multiplesOfFive = 5 * (numberOfMultiplesOfFive * (numberOfMultiplesOfFive + 1) / 2);
            long multiplesOfFifteen = 15 * (numberOfMultiplesOfFifteen * (numberOfMultiplesOfFifteen + 1) / 2);

            return multiplesOfThree + multiplesOfFive - multiplesOfFifteen;
        }
    }
}
