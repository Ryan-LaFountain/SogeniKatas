using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SogeniKatas.UnitTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void EvaluateNumber_RegularNumbersReturnStringRepresentationofNumber()
        {
            string test1 = FizzBuzz.EvaluateNumber(1);
            string test2 = FizzBuzz.EvaluateNumber(2);
            string test3 = FizzBuzz.EvaluateNumber(4);

            Assert.AreEqual("1", test1);
            Assert.AreEqual("2", test2);
            Assert.AreEqual("4", test3);
        }

        [TestMethod]
        public void EvaluateNumber_RegularNumbersDivisibleByThreeReturnFizz()
        {
            string test1 = FizzBuzz.EvaluateNumber(3);
            string test2 = FizzBuzz.EvaluateNumber(9);
            string test3 = FizzBuzz.EvaluateNumber(123);

            Assert.AreEqual("fizz", test1);
            Assert.AreEqual("fizz", test2);
            Assert.AreEqual("fizz", test3);
        }

        [TestMethod]
        public void EvaluateNumber_RegularNumbersDivisibleByFiveReturnBuzz()
        {
            string test1 = FizzBuzz.EvaluateNumber(5);
            string test2 = FizzBuzz.EvaluateNumber(20);
            string test3 = FizzBuzz.EvaluateNumber(200);

            Assert.AreEqual("buzz", test1);
            Assert.AreEqual("buzz", test2);
            Assert.AreEqual("buzz", test3);
        }

        [TestMethod]
        public void EvaluateNumber_RegularNumbersDivisibleByThreeAndFiveReturnFizzBuzz()
        {
            string test1 = FizzBuzz.EvaluateNumber(15);
            string test2 = FizzBuzz.EvaluateNumber(45);
            string test3 = FizzBuzz.EvaluateNumber(315);

            Assert.AreEqual("fizz buzz", test1);
            Assert.AreEqual("fizz buzz", test2);
            Assert.AreEqual("fizz buzz", test3);
        }




    }
}
