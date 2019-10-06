using System;

using Business.Exceptions;
using Business.Logic;

using NUnit.Framework;

namespace BusinessTests.Logic
{
    [TestFixture]
    public class LetterTests
    {
        public Letter GetLetterInstance()
        {
            return new Letter();
        }


        [Test]
        public void PassGivenTextReturnsValidNumberOfRepeats()
        {
            // Arrange
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Eanean sodales justo et Enim ornare, a congue lacus commodo.";
            var instance = GetLetterInstance();

            // Act
            var result = instance.FindNumberOfRepetations<Char>(text.ToCharArray(), 'e');

            // Assert
            Assert.AreEqual(result, 10);
        }

        [Test]
        public void FailGivenWrongTypeListThrowException()
        {
            // Arrange
            int[] list = { 1, 2, 3, 4 };
            var instance = GetLetterInstance();

            // Assert
            Assert.Throws<CountExceptions>(() => instance.FindNumberOfRepetations<int>(list, 2));
        }

        [Test]
        public void FailGivenEmptyListThrowException()
        {
            // Arrange
            string text = "";
            var instance = GetLetterInstance();

            // Assert
            Assert.Throws<CountExceptions>(() => instance.FindNumberOfRepetations<Char>(text.ToCharArray(), 'e'));
        }

        [Test]
        public void FailGivenNullItemThrowException()
        {
            // Arrange
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Eanean sodales justo et Enim ornare, a congue lacus commodo.";
            var instance = GetLetterInstance();

            // Assert
            Assert.Throws<CountExceptions>(() => instance.FindNumberOfRepetations<Char>(text.ToCharArray(), new Char()));
        }
    }
}
