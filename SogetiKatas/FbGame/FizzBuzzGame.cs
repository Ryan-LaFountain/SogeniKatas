using SogetiKatas.FbGame;
using SogetiKatas.FbGame.Rules;
using System;
using System.Collections.Generic;

namespace SogetiKatas
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
                        new Fizz(),
                        new Buzz(),
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
                        new Fizz(),
                        new Buzz()
                    };
                    break;
            }

        }
        public string EvaluateNumber(int number)
        {
            List<string> outputs = new List<string>();

            foreach(var rule in _gameRules)
            {
                if (rule.Is(number))
                    outputs.Add(rule.Output);
            }

            if(outputs.Count == 0)
                return number.ToString();

            return string.Join(" ", outputs);
        }

        public void AddCustomGameRule(int multiple, string output)
        {
            if (_gameType != GameType.Custom)
                throw new Exception("Game Mode must be custom to add custom game rules.");

            _gameRules.Add(new CustomRule(multiple, output));
        }

    }
}
