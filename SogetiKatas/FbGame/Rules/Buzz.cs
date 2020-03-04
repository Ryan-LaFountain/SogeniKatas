using System;
using System.Collections.Generic;
using System.Text;

namespace SogetiKatas.FbGame.Rules
{
    public class Buzz : IFizzBuzzRule
    {
        public string Output => "buzz";

        public bool Is(int number)
        {
            return number % 5 == 0;
        }
    }
}
