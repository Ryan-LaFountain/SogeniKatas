using System;
using System.Collections.Generic;
using System.Text;

namespace SogeniKatas.FbGame.Rules
{
    public class BuzzPop : IFizzBuzzRule
    {
        public string Output => "buzz pop";

        public bool Is(int number)
        {
            return number % 5 == 0 && number % 7 == 0;
        }
    }
}
