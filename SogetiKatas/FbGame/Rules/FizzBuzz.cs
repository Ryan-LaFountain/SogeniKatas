using System;
using System.Collections.Generic;
using System.Text;

namespace SogeniKatas.FbGame.Rules
{
    public class FizzBuzz : IFizzBuzzRule
    {
        public string Output => "fizz buzz";

        public bool Is(int number)
        {
            return number % 5 == 0 && number % 3 == 0;
        }
    }
}
