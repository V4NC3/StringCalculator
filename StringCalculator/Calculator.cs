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

            if(numberArray.Any(x => x < 0))
                throw new Exception($"negatives not allowed {string.Join(" ", numberArray.Where(x => x < 0))}");

            return numberArray.Sum(x => x);
        }

        private static void GetNumberArrayDefaultDelimiter(ref string[] numberArray)
        {
            if (!numberArray[0].StartsWith("//"))
                return;
            
            var delimiter = Convert.ToChar(numberArray[0].Remove(0, 2));
            numberArray = numberArray[1].Split(delimiter);
        }
    }
}