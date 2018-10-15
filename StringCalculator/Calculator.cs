namespace StringCalculator
{
    public class Calculator
    {
        public static int Add(string number)
        {
            return string.IsNullOrEmpty(number) ? 0 : int.Parse(number);
        }
    }
}