using System;
using System.Collections.Generic;
using System.Text;

namespace SogeniKatas.FbGame.Rules
{
    public class FizzPop : IFizzBuzzRule
    {
        public string Output => "fizz pop";

        public bool Is(int number)
        {
            return number % 3 == 0 && number % 7 == 0;
        }
    }
}
