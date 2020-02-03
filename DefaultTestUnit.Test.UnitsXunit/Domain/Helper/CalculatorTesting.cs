using System;
using DefaultTestUnit.Domain.Helpers;
using DefaultTestUnit.Domain.Interfaces;
using Moq;
using Xunit;

namespace DefaultTestUnit.Test.UnitXunit.Domain
{
    public class CalculatorUnitTesting
    {
        [Theory]
        [InlineData(new double[] {})]
        public void Sum_ListNumbers_Void_Should_Returned_Zero(double[] listNumbers)
        {
            //Arrange
            double result = 0;
            double expected = 0;
            Calculator calculatorAppService = new Calculator();
            //Action
            result = calculatorAppService.Sum(listNumbers);
            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new double[] { 1, 2, 2 })]
        public void Sum_ListNumbers_Should_Returned_Five(double[] listNumbers)
        {
            //Arrange
            double result = 0;
            double expected = 5;
            Calculator calculatorAppService = new Calculator();
            //Action
            result = calculatorAppService.Sum(listNumbers);
            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new double[] { 0.2, 3 })]
        public void Multiply_ListNumbers_Should_Returned_Six(double[] listNumbers)
        {
            //Arrange
            double result = 0;
            double expected = 0.60000000000000009;
            Calculator calculatorAppService = new Calculator();
            //Action
            result = calculatorAppService.Multiply(listNumbers);
            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Sum_ListNumbersWithFloatNumbers_Should_Returned_Two_Moq()
        {
            //Arrange
            double[] listNumbers = { 0.5, 0.5, 1 };
            ICalculator calculator = new Calculator();
            var calculatorAppService = new Mock<ICalculator>();
            calculatorAppService.Setup(x => x.Sum(listNumbers)).Returns(2);
            //Action
            var expected = calculatorAppService.Object.Sum(listNumbers);
            var actual = calculator.Sum(listNumbers);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
