using System;
using System.Collections.Generic;
using System.Text;

namespace SogeniKatas
{
    public static class StringCalculator
    {
        public static int Add(string numbers)
        {
            if (String.IsNullOrWhiteSpace(numbers))
                return 0;

            string[] numbersArray = numbers.Split(new string[] {",","\n" }, StringSplitOptions.None);

            int result = 0;

            foreach(var number in numbersArray)
            {
                result += Convert.ToInt32(number);
            }

            return result;
        }
    }
}
