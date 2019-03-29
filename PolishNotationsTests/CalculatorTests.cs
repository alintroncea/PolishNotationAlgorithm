using System;
using Xunit;

namespace PolishNotationAlgorithm
{
    public class CalculatorTests
    {
        Calculator calculate = new Calculator();
        [Fact]
        public void ShouldReturnAddResult()
        {
            Assert.Equal(5, calculate.GetResult('+', 2, 3));
        }

        [Fact]
        public void ShouldReturnSubtractResult()
        {
            Assert.Equal(3, calculate.GetResult('-', 6, 3));
        }
        [Fact]
        public void ShouldReturnMultiplyResult()
        {
            Assert.Equal(4, calculate.GetResult('*', 2, 2));
        }
        [Fact]
        public void ShouldReturnDivideResult()
        {
            Assert.Equal(3.5, calculate.GetResult('/', 7.0, 2));
        }
        [Fact]
        public void ShouldReturn0WhenOperatorIsNotCorrect()
        {
            Assert.Equal(0, calculate.GetResult('^', 7, 2));
        }
    }
}
