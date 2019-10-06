using System;

using Business.Exceptions;
using Business.Logic;

using NUnit.Framework;

namespace BusinessTests.Logic
{
    [TestFixture]
    public class NumberTests
    {
        public Number GetNumberInstance()
        {
            return new Number();
        }


        [Test]
        public void PassGivenNumbersReturnsValidNumberOfRepeats()
        {
            // Arrange
            int[] list = { 1, 2, 3, 4, 2, 2, 2, 2, 22, 2, 2, 2, 2, 4, 2 };
            var instance = GetNumberInstance();

            // Act
            var result = instance.FindNumberOfRepetations<int>(list, 2);

            // Assert
            Assert.AreEqual(result, 10);
        }

        [Test]
        public void FailGivenEmptyListThrowException()
        {
            // Arrange
            int[] list = { };
            var instance = GetNumberInstance();

            // Assert
            Assert.Throws<CountExceptions>(() => instance.FindNumberOfRepetations<int>(list, 2));
        }

        [Test]
        public void FailGivenWrongTypeListThrowException()
        {
            // Arrange
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Eanean sodales justo et Enim ornare, a congue lacus commodo.";
            var instance = GetNumberInstance();

            // Assert
            Assert.Throws<CountExceptions>(() => instance.FindNumberOfRepetations<Char>(text.ToCharArray(), new Char()));
        }
    }
}
