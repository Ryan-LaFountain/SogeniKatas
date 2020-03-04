using Microsoft.VisualStudio.TestTools.UnitTesting;
using SogetiKatas.Bowling;
using SogetiKatas.FbGame;

namespace SogetiKatas.UnitTests
{
    [TestClass]
    public class BowlingTests
    {
        [TestMethod]
        public void IsStrike_EvaluatesTrueWhenFirstRollIs10()
        {
            var frame = new Frame() { FirstRoll = 10 };

            var result = frame.IsStrike;

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void IsStrike_EvaluatesFalseWhenFirstRollIsLessThan10()
        {
            var frame = new Frame() { FirstRoll = 9 };

            var result = frame.IsStrike;

            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void IsSpare_EvaluatesToFalseWhenFirstRollIs10()
        {
            var frame = new Frame() { FirstRoll = 10 };

            var result = frame.IsSpare;

            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void IsSpare_EvaluatesToFalseWhenTwoRollsLessThan10()
        {
            var frame = new Frame() { FirstRoll = 3, SecondRoll = 6 };

            var result = frame.IsSpare;

            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void IsSpare_EvaluatesToTrueWhenTwoRollsEqualTen()
        {
            var frame = new Frame() { FirstRoll = 3, SecondRoll = 7 };

            var result = frame.IsSpare;

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void GetScore_AllStrikesResultsInPerfectScore()
        {
            var game = new BowlingGame();
            game.Frames.Add(new Frame() { FirstRoll = 10 });
            game.Frames.Add(new Frame() { FirstRoll = 10 });
            game.Frames.Add(new Frame() { FirstRoll = 10 });
            game.Frames.Add(new Frame() { FirstRoll = 10 });
            game.Frames.Add(new Frame() { FirstRoll = 10 });
            game.Frames.Add(new Frame() { FirstRoll = 10 });
            game.Frames.Add(new Frame() { FirstRoll = 10 });
            game.Frames.Add(new Frame() { FirstRoll = 10 });
            game.Frames.Add(new Frame() { FirstRoll = 10 });
            game.Frames.Add(new TenthFrame() { FirstRoll = 10, SecondRoll = 10, BonusRoll = 10 });

            var score = game.GetScore();

            Assert.AreEqual(300, score);
        }

        [TestMethod]
        public void GetScore_AllSparesWithNineBonusRollReturnsCorrectResult()
        {
            var game = new BowlingGame();
            game.Frames.Add(new Frame() { FirstRoll = 9, SecondRoll = 1 });
            game.Frames.Add(new Frame() { FirstRoll = 9, SecondRoll = 1 });
            game.Frames.Add(new Frame() { FirstRoll = 9, SecondRoll = 1 });
            game.Frames.Add(new Frame() { FirstRoll = 9, SecondRoll = 1 });
            game.Frames.Add(new Frame() { FirstRoll = 9, SecondRoll = 1 });
            game.Frames.Add(new Frame() { FirstRoll = 9, SecondRoll = 1 });
            game.Frames.Add(new Frame() { FirstRoll = 9, SecondRoll = 1 });
            game.Frames.Add(new Frame() { FirstRoll = 9, SecondRoll = 1 });
            game.Frames.Add(new Frame() { FirstRoll = 9, SecondRoll = 1 });
            game.Frames.Add(new TenthFrame() { FirstRoll = 9, SecondRoll = 1, BonusRoll = 9 });

            var score = game.GetScore();

            Assert.AreEqual(190, score);
        }

        [TestMethod]
        public void GetScore_NoSparesOrStrikesReturnsCorrectResult()
        {
            var game = new BowlingGame();
            game.Frames.Add(new Frame() { FirstRoll = 4, SecondRoll = 4 });
            game.Frames.Add(new Frame() { FirstRoll = 4, SecondRoll = 4 });
            game.Frames.Add(new Frame() { FirstRoll = 4, SecondRoll = 4 });
            game.Frames.Add(new Frame() { FirstRoll = 4, SecondRoll = 4 });
            game.Frames.Add(new Frame() { FirstRoll = 4, SecondRoll = 4 });
            game.Frames.Add(new Frame() { FirstRoll = 4, SecondRoll = 4 });
            game.Frames.Add(new Frame() { FirstRoll = 4, SecondRoll = 4 });
            game.Frames.Add(new Frame() { FirstRoll = 4, SecondRoll = 4 });
            game.Frames.Add(new Frame() { FirstRoll = 4, SecondRoll = 4 });
            game.Frames.Add(new TenthFrame() { FirstRoll = 4, SecondRoll = 4 });

            var score = game.GetScore();

            Assert.AreEqual(80, score);
        }

        [TestMethod]
        public void GetScore_MixedScoreReturnsCorrectResult()
        {
            var game = new BowlingGame();
            game.Frames.Add(new Frame() { FirstRoll = 10});
            game.Frames.Add(new Frame() { FirstRoll = 7, SecondRoll = 2 });
            game.Frames.Add(new Frame() { FirstRoll = 4, SecondRoll = 6 });
            game.Frames.Add(new Frame() { FirstRoll = 10 });
            game.Frames.Add(new Frame() { FirstRoll = 10});
            game.Frames.Add(new Frame() { FirstRoll = 5, SecondRoll = 5 });
            game.Frames.Add(new Frame() { FirstRoll = 9, SecondRoll = 1 });
            game.Frames.Add(new Frame() { FirstRoll = 8, SecondRoll = 1 });
            game.Frames.Add(new Frame() { FirstRoll = 10 });
            game.Frames.Add(new TenthFrame() { FirstRoll = 10, SecondRoll = 9, BonusRoll = 0 });

            var score = game.GetScore();

            Assert.AreEqual(187, score);
        }

    }
}
