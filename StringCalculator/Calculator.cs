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

            return numberArray.Sum(x => int.Parse(x));
        }
    }
}