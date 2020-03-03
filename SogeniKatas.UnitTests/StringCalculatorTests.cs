using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SogeniKatas.UnitTests
{
    [TestClass]
    public class StringCalculatorTests
    {
        [TestMethod]
        public void Add_EmptyStringReturnsZero()
        {
            int result = StringCalculator.Add("");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Add_PassingSingleNumberReturnsNumber()
        {
            int result = StringCalculator.Add("123");

            Assert.AreEqual(123, result);
        }

        [TestMethod]
        public void Add_PassingTwoNumberReturnsCorrectSum()
        {
            int result = StringCalculator.Add("12,20");

            Assert.AreEqual(32, result);
        }

        [TestMethod]
        public void Add_PassingAnyAmountOfNumbersBetween1and1000ReturnsCorrectSum()
        {
            //Arrange
            Random randomNumberGenerator = new Random();
            int iterations = randomNumberGenerator.Next(1, 1000);
            List<int> numbers = new List<int>();
            for(int i = 0; i < iterations; i++)
            {
                numbers.Add(randomNumberGenerator.Next(1, 100));
            }

            string numbersString = string.Join(",", numbers.Select(i => i.ToString()).ToArray());

            int expectedResult = numbers.Sum();

            //Act
            int result = StringCalculator.Add(numbersString);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Add_SeperatingNumbersByNewLineReturnsCorrectSum()
        {
            //Arrange
            var newLineString = "10\n20\n30\n40";

            //Act
            int result = StringCalculator.Add(newLineString);

            //Assert
            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void Add_SeperatingNumbersByNewLineOrCommaReturnsCorrectSum()
        {
            //Arrange
            var mixedSeperatorString = "10\n20,30\n40";

            //Act
            int result = StringCalculator.Add(mixedSeperatorString);

            //Assert
            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void Add_PassingCustomDelimiterReturnsCorrectSum()
        {
            //Arrange
            var customDelimiterString = "//foo\n20foo30foo50";

            //Act
            int result = StringCalculator.Add(customDelimiterString);

            //Assert
            Assert.AreEqual(100, result);

        }
    }
}
