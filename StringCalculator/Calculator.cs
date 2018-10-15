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
            if (numberArray[0].StartsWith("//"))
            {
                var delimiter = Convert.ToChar(numberArray[0].Remove(0, 2));
                numberArray = numberArray[1].Split(delimiter);
            }

            return numberArray.Sum(x => int.Parse(x));
        }
    }
}