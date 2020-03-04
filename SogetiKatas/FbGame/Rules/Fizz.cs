using System;
using System.Collections.Generic;
using System.Text;

namespace SogetiKatas.FbGame.Rules
{
    public class Fizz : IFizzBuzzRule
    {
        public string Output => "fizz";

        public bool Is(int number)
        {
            return number % 3 == 0;
        }
    }
}
