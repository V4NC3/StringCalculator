using System;
using System.Linq;

namespace StringCalculator
{
    public class Calculator
    {
        public static int Add(string number)
        {
            const char delimiter = ',';
            if (string.IsNullOrEmpty(number))
            return 0;

            var numberStringArray = number.Replace('\n', delimiter)
                                    .Split(delimiter);

            // Delimiter condition check
            GetNumberArrayDefaultDelimiter(ref numberStringArray, delimiter);
            var numberArray = numberStringArray.Select(int.Parse).ToArray();

            ValidateNonNegative(numberArray);

            return numberArray.Where(x => x <= 1000).Sum(x => x);
        }

        private static void ValidateNonNegative(int[] numberArray)
        {
            if (numberArray.Any(x => x < 0))
                throw new Exception($"negatives not allowed {string.Join(" ", numberArray.Where(x => x < 0))}");
        }

        private static void GetNumberArrayDefaultDelimiter(ref string[] numberArray, char delimiter)
        {
            if (!numberArray[0].StartsWith("//"))
                return;
            
            var customDelimiter = numberArray[0].Remove(0, 2);
            numberArray[1] = numberArray[1].Replace(customDelimiter, delimiter.ToString());
            numberArray = numberArray[1].Split(delimiter);
        }
    }
}