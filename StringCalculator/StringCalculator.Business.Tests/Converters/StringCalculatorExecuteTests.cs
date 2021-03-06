﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        [TestMethod]
        public void ShouldReturnThree_WhenStringContainsOneAndTwo()
        {
            Assert.AreEqual(3, _calculator.Execute("1,2"));
        }

        [TestMethod]
        public void ShouldReturnTenWithMithMultipleNumbers()
        {
            Assert.AreEqual(10, _calculator.Execute("1,2,3,4"));
        }

        [TestMethod]
        public void ShouldReturnSum_WhenStringContainsNewLineCharacters()
        {
            Assert.AreEqual(6, _calculator.Execute("1\n2,3"));
        }

        [TestMethod]
        public void ShouldReturnSum_WhenStringContainsDifferentDelimiter()
        {
            Assert.AreEqual(3, _calculator.Execute("//;\n1;2"));
        }
    }
}