using System;
using System.Collections.Generic;
using System.Text;

namespace SogetiKatas.Bowling
{
    public class Frame
    {
        public int FirstRoll { get; set; }

        public int SecondRoll { get; set; }

        public bool IsStrike => FirstRoll == 10;

        public bool IsSpare => FirstRoll + SecondRoll == 10 && !IsStrike;

        public int Score { get; set; }
    }
}
