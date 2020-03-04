using Microsoft.VisualStudio.TestTools.UnitTesting;
using SogetiKatas.FbGame;

namespace SogetiKatas.UnitTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void EvaluateNumber_RegularNumbersReturnStringRepresentationofNumber()
        {
            var game = new FizzBuzzGame(GameType.FizzBuzz);
            string test1 = game.EvaluateNumber(1);
            string test2 = game.EvaluateNumber(2);
            string test3 = game.EvaluateNumber(4);

            Assert.AreEqual("1", test1);
            Assert.AreEqual("2", test2);
            Assert.AreEqual("4", test3);
        }

        [TestMethod]
        public void EvaluateNumber_RegularNumbersDivisibleByThreeReturnFizz()
        {
            var game = new FizzBuzzGame(GameType.FizzBuzz);
            string test1 = game.EvaluateNumber(3);
            string test2 = game.EvaluateNumber(9);
            string test3 = game.EvaluateNumber(123);

            Assert.AreEqual("fizz", test1);
            Assert.AreEqual("fizz", test2);
            Assert.AreEqual("fizz", test3);
        }

        [TestMethod]
        public void EvaluateNumber_RegularNumbersDivisibleByFiveReturnBuzz()
        {
            var game = new FizzBuzzGame(GameType.FizzBuzz);
            string test1 = game.EvaluateNumber(5);
            string test2 = game.EvaluateNumber(20);
            string test3 = game.EvaluateNumber(200);

            Assert.AreEqual("buzz", test1);
            Assert.AreEqual("buzz", test2);
            Assert.AreEqual("buzz", test3);
        }

        [TestMethod]
        public void EvaluateNumber_RegularNumbersDivisibleByThreeAndFiveReturnFizzBuzz()
        {
            var game = new FizzBuzzGame(GameType.FizzBuzz);
            string test1 = game.EvaluateNumber(15);
            string test2 = game.EvaluateNumber(45);
            string test3 = game.EvaluateNumber(315);

            Assert.AreEqual("fizz buzz", test1);
            Assert.AreEqual("fizz buzz", test2);
            Assert.AreEqual("fizz buzz", test3);
        }

        [TestMethod]
        public void EvaluateNumber_MultiplesOfSevenReturnPop()
        {
            var game = new FizzBuzzGame(GameType.FizzBuzzPop);
            string test1 = game.EvaluateNumber(7);
            string test2 = game.EvaluateNumber(28);
            string test3 = game.EvaluateNumber(77);

            Assert.AreEqual("pop", test1);
            Assert.AreEqual("pop", test2);
            Assert.AreEqual("pop", test3);
        }

        [TestMethod]
        public void EvaluateNumber_MultiplesofThreendSevenReturnFizzPop()
        {
            var game = new FizzBuzzGame(GameType.FizzBuzzPop);
            string test1 = game.EvaluateNumber(21);
            string test2 = game.EvaluateNumber(63);
            string test3 = game.EvaluateNumber(126);

            Assert.AreEqual("fizz pop", test1);
            Assert.AreEqual("fizz pop", test2);
            Assert.AreEqual("fizz pop", test3);
        }

        [TestMethod]
        public void EvaluateNumber_MultiplesOfFiveAndSevenReturnBuzzPop()
        {
            var game = new FizzBuzzGame(GameType.FizzBuzzPop);
            string test1 = game.EvaluateNumber(35);
            string test2 = game.EvaluateNumber(70);
            string test3 = game.EvaluateNumber(140);

            Assert.AreEqual("buzz pop", test1);
            Assert.AreEqual("buzz pop", test2);
            Assert.AreEqual("buzz pop", test3);
        }

        [TestMethod]
        public void EvaluateNumber_MultiplesOfFiveAndSevenReturnFizzBuzzPop()
        {
            var game = new FizzBuzzGame(GameType.FizzBuzzPop);
            string test1 = game.EvaluateNumber(105);
            string test2 = game.EvaluateNumber(210);
            string test3 = game.EvaluateNumber(315);

            Assert.AreEqual("fizz buzz pop", test1);
            Assert.AreEqual("fizz buzz pop", test2);
            Assert.AreEqual("fizz buzz pop", test3);
        }

        [TestMethod]
        public void EvaluateNumber_CustomGameWhenMultipleOfTwoSelectedFuzzIsReturned()
        {
            //Arrange
            var game = new FizzBuzzGame(GameType.Custom);
            game.AddCustomGameRule(2, "fuzz");

            //Act
            string test1 = game.EvaluateNumber(1);
            string test2 = game.EvaluateNumber(2);
            string test3 = game.EvaluateNumber(8);


            //Assert
            Assert.AreEqual("1", test1);
            Assert.AreEqual("fuzz", test2);
            Assert.AreEqual("fuzz", test3);
        }

        [TestMethod]
        public void EvaluateNumber_TwoCustomGameRulesReturnCorrectResult()
        {
            //Arrange
            var game = new FizzBuzzGame(GameType.Custom);
            game.AddCustomGameRule(2, "fuzz");
            game.AddCustomGameRule(3, "bizz");

            //Act
            string test1 = game.EvaluateNumber(4);
            string test2 = game.EvaluateNumber(9);
            string test3 = game.EvaluateNumber(12);


            //Assert
            Assert.AreEqual("fuzz", test1);
            Assert.AreEqual("bizz", test2);
            Assert.AreEqual("fuzz bizz", test3);
        }
    }
}
