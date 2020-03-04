using System;
using System.Collections.Generic;
using System.Text;

namespace SogetiKatas.Bowling
{
    public class TenthFrame: Frame
    {
        public int BonusRoll { get; set; }

        public bool SecondRollStrike => SecondRoll == 10;
    }
}
