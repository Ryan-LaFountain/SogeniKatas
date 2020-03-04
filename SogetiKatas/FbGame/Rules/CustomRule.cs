using System;
using System.Collections.Generic;
using System.Text;

namespace SogetiKatas.FbGame.Rules
{
    public class CustomRule : IFizzBuzzRule
    {
        private int _multiple;
        private string _output;

        public CustomRule(int multiple, string output)
        {
            _multiple = multiple;
            _output = output;
        }
        public string Output => _output;

        public bool Is(int number)
        {
            throw new NotImplementedException();
        }
    }
}
