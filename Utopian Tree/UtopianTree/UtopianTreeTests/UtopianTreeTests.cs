using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtopianTree;

namespace UtopianTreeTests
{
    [TestClass]
    public class UtopianTreeTests
    {
        [TestMethod]
        public void TestCaseOne()
        {
            // Arrange
            int expected = 1;

            // Act
            int actual = Program.GetHeightByCycles(0);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCaseTwo()
        {
            // Arrange
            int expected = 2;

            // Act
            int actual = Program.GetHeightByCycles(1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCaseThree()
        {
            // Arrange
            int expected = 7;

            // Act
            int actual = Program.GetHeightByCycles(4);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
