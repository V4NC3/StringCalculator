using NUnit.Framework;

namespace StringCalculator
{
    [TestFixture]
    public class StringCalculator
    {
        // Created test to return 0 when empty string.
        [TestCase(0,"")]

        // Created test to return 1 when 1 string.
        [TestCase(1, "1")]

        // Created test to return 3 when string 1 + 2.
        [TestCase(3, "1,2")]

        public void Add_Number_ReturnSum(int expected, string number)
        {
            Assert.AreEqual(expected, Calculator.Add(number));
        }
    }
}
