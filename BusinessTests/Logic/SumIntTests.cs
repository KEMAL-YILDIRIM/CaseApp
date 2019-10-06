using Business.Logic;

using NUnit.Framework;

namespace BusinessTests.Logic
{
    [TestFixture]
    public class SumIntTests
    {
        public SumInt GetSumIntInstance()
        {
            return new SumInt();
        }


        [Test]
        public void PassGivenNumbersReturnsValidResult()
        {
            // Arrange
            var instance = GetSumIntInstance();

            // Act
            var operatorType = instance.GetOperatorType;
            var result = instance.Operate(3, 5);

            // Assert
            Assert.AreEqual(operatorType, "+");
            Assert.AreEqual(result, 8);
        }

        [Test]
        public void PassGivenNegativeNumbersReturnsValidResult()
        {
            // Arrange
            var instance = GetSumIntInstance();

            // Act
            var operatorType = instance.GetOperatorType;
            var result = instance.Operate(3, -5);

            // Assert
            Assert.AreEqual(operatorType, "+");
            Assert.AreEqual(result, -2);
        }

        [Test]
        public void PassGivenZeroReturnsValidZoreResult()
        {
            // Arrange
            var instance = GetSumIntInstance();

            // Act
            var operatorType = instance.GetOperatorType;
            var result = instance.Operate(0, 0);

            // Assert
            Assert.AreEqual(operatorType, "+");
            Assert.AreEqual(result, 0);
        }
    }
}
