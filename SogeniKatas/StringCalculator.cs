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

            string customDelimiter;
            string[] delimiters;

            if (numbers.StartsWith("//"))
            {
                var startIndex = 2;
                var length = numbers.IndexOf("\n") - startIndex;
                customDelimiter = numbers.Substring(startIndex,length);
                numbers = numbers.Substring(numbers.IndexOf("\n") + 1);
                delimiters = new string[] { customDelimiter };
            }
            else
            {
                delimiters = new string[] { ",", "\n" };
            }

            string[] numbersArray = numbers.Split(delimiters, StringSplitOptions.None);

            int result = 0;

            foreach(var number in numbersArray)
            {
                result += Convert.ToInt32(number);
            }

            return result;
        }
    }
}
