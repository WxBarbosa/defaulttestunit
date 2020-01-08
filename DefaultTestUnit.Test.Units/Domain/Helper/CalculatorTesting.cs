using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DefaultTestUnit.Domain.Helpers;

namespace DefaultTestUnit.Test.Unit.Domain
{
    [TestClass]
    public class CalculatorUnitTesting
    {
        [TestMethod]
        public void Sum_ListNumbers_Void_Should_Returned_Zero()
        {
            //Arrange
            double result = 0;
            double expected = 0;
            double[] listNumbers = { };
            Calculator calculatorAppService = new Calculator();
            //Action
            result = calculatorAppService.Sum(listNumbers);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Sum_ListNumbers_Should_Returned_Five()
        {
            //Arrange
            double result = 0;
            double expected = 5;
            double[] listNumbers = { 1, 2, 2 };
            Calculator calculatorAppService = new Calculator();
            //Action
            result = calculatorAppService.Sum(listNumbers);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Sum_ListNumbersWithFloatNumbers_Should_Returned_Two()
        {
            //Arrange
            double result = 0;
            double expected = 2;
            double[] listNumbers = { 0.5, 0.5, 1 };
            Calculator calculatorAppService = new Calculator();
            //Action
            result = calculatorAppService.Sum(listNumbers);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Multiply_ListNumbers_Should_Returned_Six()
        {
            //Arrange
            double result = 0;
            double expected = 0.60000000000000009;
            double[] listNumbers = { 0.2, 3 };
            Calculator calculatorAppService = new Calculator();
            //Action
            result = calculatorAppService.Multiply(listNumbers);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
