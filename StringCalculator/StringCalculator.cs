using NUnit.Framework;

namespace StringCalculator
{
    [TestFixture]
    public class StringCalculator
    {
        // Created test to return 0 when empty string.
        [TestCase(0,"")]

        // Created test to return 0 when empty string.
        [TestCase(1, "1")]

        public void Add_Number_ReturnSum(int expected, string number)
        {
            Assert.AreEqual(expected, Calculator.Add(number));
        }
    }
}
