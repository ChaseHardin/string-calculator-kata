using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalculator.Business.Tests.Converters
{
    [TestClass]
    public class StringCalculatorExecuteTests
    {
        private Business.Converters.StringCalculator _calculator;

        [TestInitialize]
        public void TestInitialize()
        {
            _calculator = new Business.Converters.StringCalculator();
        }

        [TestMethod]
        public void ShouldReturnZero_WhenEmptyString()
        {
            Assert.AreEqual(0, _calculator.Execute(""));
        }

        [TestMethod]
        public void ShouldReturnOne_WhenStringContainsOne()
        {
            Assert.AreEqual(1, _calculator.Execute("1"));
        }

        [TestMethod]
        public void ShouldReturnTwo_WhenStringContainsTwo()
        {
            Assert.AreEqual(2, _calculator.Execute("2"));
        }
    }
}