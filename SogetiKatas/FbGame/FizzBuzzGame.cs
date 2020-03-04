using SogeniKatas.FbGame;
using SogeniKatas.FbGame.Rules;
using SogeniKatas.FBGame.Rules;
using System;
using System.Collections.Generic;

namespace SogeniKatas
{
    public class FizzBuzzGame
    {
        private List<IFizzBuzzRule> _gameRules;
        private GameType _gameType;
        public FizzBuzzGame(GameType gameType)
        {
            _gameType = gameType;
            switch (gameType)
            {
                case GameType.FizzBuzzPop:
                    _gameRules = new List<IFizzBuzzRule>()
                    {
                        new FizzBuzzPop(),
                        new BuzzPop(),
                        new FizzPop(),
                        new Pop()
                    };
                    break;
                case GameType.Custom:
                    _gameRules = new List<IFizzBuzzRule>();
                    break;
                case GameType.FizzBuzz:
                default:
                    _gameRules = new List<IFizzBuzzRule>()
                    {
                        new FizzBuzz(),
                        new Fizz(),
                        new Buzz(),
                    };
                    break;
            }

        }
        public string EvaluateNumber(int number)
        {
            foreach(var rule in _gameRules)
            {
                if (rule.Is(number))
                    return rule.Output;
            }

            return number.ToString();
        }

        public void AddCustomGameRule(int multiple, string output)
        {
            if (_gameType != GameType.Custom)
                throw new Exception("Game Mode must be custom to add custom game rules.");
        }

        private Exception Exception(string v)
        {
            throw new NotImplementedException();
        }
    }
}
