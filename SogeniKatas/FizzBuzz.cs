using System;
using System.Collections.Generic;
using System.Text;

namespace SogeniKatas
{
    public static class FizzBuzz
    {
        public static string EvaluateNumber(int number)
        {
            if (IsFizzBuzz(number))
                return "fizz buzz";
            else if (IsFizz(number))
                return "fizz";
            else if (IsBuzz(number))
                return "buzz";
            else
                return number.ToString();
        }

        public static bool IsFizz(int number)
        {
            return number % 3 == 0;
        }

        public static bool IsBuzz(int number)
        {
            return number % 5 == 0;
        }

        public static bool IsFizzBuzz(int number)
        {
            return IsFizz(number) && IsBuzz(number);
        }
    }
}
