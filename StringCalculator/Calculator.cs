using System;
using System.Linq;

namespace StringCalculator
{
    public class Calculator
    {
        public static int Add(string number)
        {
            if (string.IsNullOrEmpty(number))
            return 0;

            var numberStringArray = number.Replace("\n",",")
                                    .Split(',');

            // Delimiter condition check
            GetNumberArrayDefaultDelimiter(ref numberStringArray);
            var numberArray = numberStringArray.Select(int.Parse).ToArray();

            ValidateNonNegative(numberArray);

            return numberArray.Where(x => x <= 1000).Sum(x => x);
        }

        private static void ValidateNonNegative(int[] numberArray)
        {
            if (numberArray.Any(x => x < 0))
                throw new Exception($"negatives not allowed {string.Join(" ", numberArray.Where(x => x < 0))}");
        }

        private static void GetNumberArrayDefaultDelimiter(ref string[] numberArray)
        {
            if (!numberArray[0].StartsWith("//"))
                return;
            
            var delimiter = numberArray[0].Remove(0, 2);
            numberArray[1] = numberArray[1].Replace(delimiter, ",");
            numberArray = numberArray[1].Split(',');
        }
    }
}