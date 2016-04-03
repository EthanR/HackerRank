using System;
using System.Collections.Generic;
using System.Linq;
using BasicStatisticsWarmUp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicStatisticsWarmUpTests
{
    [TestClass]
    public class ProgramTest
    {
        //Sample Input

        //10
        //64630 11735 14216 99233 14470 4978 73429 38120 51135 67060

        //Sample Output

        //43900.6
        //44627.5
        //4978
        //30466.9

        [TestMethod]
        public void TestCaseOne()
        {
            // Arrange
            decimal expectedMean = 43900.6M;
            decimal expectedMedian = 44627.5M;
            int expectedMode = 4978;
            decimal expectedStandardDeviation = 30466.9M;
            List<int> numbers = new List<int> { 64630, 11735, 14216, 99233, 14470, 4978, 73429, 38120, 51135, 67060 };
                
            // Act
            decimal actualMean = Program.GetMean(10, numbers);
            decimal actualMedian = Program.GetMedian(10, numbers.OrderBy(number => number).ToList());
            decimal actualMode = Program.GetMode(numbers);
            decimal actualStandardDeviation = Program.GetStandardDeviation(10, numbers, expectedMean);

            // Assert
            Assert.AreEqual(expectedMean, actualMean);
            Assert.AreEqual(expectedMedian, actualMedian);
            Assert.AreEqual(expectedMode, actualMode);
            Assert.AreEqual(expectedStandardDeviation, actualStandardDeviation);
        }
    }
}
