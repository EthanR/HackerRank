using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pangram;

namespace PangramTests
{
    [TestClass]
    public class SolutionTests
    {
        [TestMethod]
        public void TestPangramCaseOne()
        {
            // Arrange
            string potentialPangram = "We promptly judged antique ivory buckles for the next prize";
            string expected = "pangram";

            // Act
            string actual = Solution.GetIsPangram(potentialPangram);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNotPangramCaseOne()
        {
            // Arrange
            string potentialPangram = "We promptly judged antique ivory buckles for the prize";
            string expected = "not pangram";

            // Act
            string actual = Solution.GetIsPangram(potentialPangram);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
