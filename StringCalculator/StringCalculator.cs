using System;
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

        // Created test to return 6 when string is 3 numbers.
        [TestCase(6, "1,2,3")]
        
        // Created test to check for new line with string is 3 numbers.
        [TestCase(6, "1\n2,3")]

        // Created test to check for Delimiter ";".
        [TestCase(3, "//;\n1;2")]

        public void Add_Number_ReturnSum(int expected, string number)
        {
            Assert.AreEqual(expected, Calculator.Add(number));
        }
        
        [Test]
        public void Add_NegativeNumber_ThrowException()
        {
            const string number = "1\n-2,-3";
            var exception = Assert.Throws<Exception>(() => Calculator.Add(number));
            Assert.AreEqual("negatives not allowed -2 -3", exception.Message);
        }
    }
}
