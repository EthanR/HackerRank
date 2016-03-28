using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiplesOfThreeAndFive;

namespace MultiplesOfThreeAndFiveTests
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void GetSumForTenTest()
        {
            // Arrange
            long expected = 23;

            // Act
            long result = Program.GetSum(10);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetSumForOneHundredTest()
        {
            // Arrange
            long expected = 2318;

            // Act
            long result = Program.GetSum(100);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
