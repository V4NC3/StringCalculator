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

            var numberArray = number.Replace("\n",",")
                                    .Split(',');

            // Delimiter condition check
            GetNumberArrayDefaultDelimiter(ref numberArray);

            if(numberArray.Any(x => int.Parse(x) < 0))
                throw new Exception($"negatives not allowed {string.Join(" ", numberArray.Where(x => int.Parse(x) < 0))}");

            return numberArray.Sum(x => int.Parse(x));
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