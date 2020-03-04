using SogeniKatas.FbGame;
using System;
using System.Collections.Generic;
using System.Text;

namespace SogeniKatas.FBGame.Rules
{
    public class FizzBuzzPop : IFizzBuzzRule
    {
        public string Output => "fizz buzz pop";

        public bool Is(int number)
        {
            return number % 7 == 0 && number % 5 == 0 && number % 3 == 0;
        }
    }
}
