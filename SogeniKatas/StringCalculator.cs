using System;
using System.Collections.Generic;
using System.Linq;
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
            List<int> negativeNumbers = new List<int>();

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
                int num = Convert.ToInt32(number);

                if (num > 1000)
                    continue;
                if (num < 0)
                    negativeNumbers.Add(num);
                else
                    result += num;
            }

            if (negativeNumbers.Count > 0)
                throw new ArgumentOutOfRangeException("numbers",$"negatives not allowed: {string.Join(",",negativeNumbers.Select(neg => neg.ToString()))}");

            return result;
        }
    }
}
