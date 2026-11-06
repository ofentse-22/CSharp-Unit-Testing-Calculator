using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AwesomeCalculator;

namespace AwesomeCalculator.Tests
{
    [TestClass]
    [DoNotParallelize]
    public class CalculatorTests
    {
        private Calculator _calculator;
        private const double Input1 = 23;
        private const double Input2 = 14;
        private const double DivideByZeroInput1 = 5;
        private const double DivideByZeroInput2 = 0;

        [TestInitialize]
        public void Setup() => _calculator = new Calculator();

        [TestMethod]
        public void Add_WithTwoNumbers_ReturnsCorrectSum()
        {
            double expected = 37;
            double actual = _calculator.Add(Input1, Input2);
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Subtract_WithTwoNumbers_ReturnsCorrectDifference()
        {
            double expected = 9;
            double actual = _calculator.Subtract(Input1, Input2);
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Multiply_WithTwoNumbers_ReturnsCorrectProduct()
        {
            double expected = 322;
            double actual = _calculator.Multiply(Input1, Input2);
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Divide_WithTwoNumbers_ReturnsCorrectQuotient()
        {
            double expected = 23.0 / 14.0;
            double actual = _calculator.Divide(Input1, Input2);
            Assert.AreEqual(expected, actual, 0.00000001);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            _calculator.Divide(DivideByZeroInput1, DivideByZeroInput2);
        }
    }
}