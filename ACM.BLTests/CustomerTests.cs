using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValid()
        {
            // Arrange
            var customer = new Customer();
            var goalSteps = "5000";
            var actualSteps = "2000";
            var expected = 40M;

            // Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValidAndSame()
        {
            // Arrange
            var customer = new Customer();
            var goalSteps = "5000";
            var actualSteps = "5000";
            var expected = 100M;

            // Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValidAndActualIsZero()
        {
            // Arrange
            var customer = new Customer();
            var goalSteps = "5000";
            var actualSteps = "0";
            var expected = 0M;

            // Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            // Assert
            Assert.AreEqual(expected, actual);
        }       

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculatePercentOfGoalStepsTestGoalIsNull()
        {
            // arrange
            var customer = new Customer();
            string goalSteps = null;
            string actualSteps = "2000";

            // act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculatePercentOfGoalStepsTestGoalIsNotNumeric()
        {
            // arrange
            var customer = new Customer();
            string goalSteps = "one";
            string actualSteps = "2000";

            // act
            try
            {
                var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Goal must be numeric", ex.Message);
                throw;
            }
        }

        //[TestMethod()]
        //public void CalculatePercentOfGoalStepsTest()
        //{
        //    Assert.Fail();
        //}
    }
}
