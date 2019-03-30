using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace PolishNotationAlgorithm
{
   public class OperationTests
    {
        Operation operation = new Operation();

        //IsOperator Tests
        [Fact]
        public void ShouldReturnTrueIf_ItsAddOperator()
        {
            
            Assert.True(operation.IsOperator("+"));
        }
        [Fact]
        public void ShouldReturnTrueIf_ItsSubtractOperator()
        {

            Assert.True(operation.IsOperator("-"));
        }
        [Fact]
        public void ShouldReturnTrueIf_ItsMultiplyOperator()
        {

            Assert.True(operation.IsOperator("*"));
        }
        [Fact]
        public void ShouldReturnTrueIf_ItsDivideOperator()
        {

            Assert.True(operation.IsOperator("/"));
        }
        [Fact]
        public void ShouldReturnFalseIf_ItsNotAValidOperator()
        {

            Assert.False(operation.IsOperator("!"));
        }
        
        //Calculator Tests
        [Fact]
        public void ShouldReturnAddResult()
        {
            Assert.Equal(5, operation.Calculator('+', 2, 3));
        }

        [Fact]
        public void ShouldReturnSubtractResult()
        {
            Assert.Equal(3, operation.Calculator('-', 6, 3));
        }
        [Fact]
        public void ShouldReturnMultiplyResult()
        {
            Assert.Equal(4, operation.Calculator('*', 2, 2));
        }
        [Fact]
        public void ShouldReturnDivideResult()
        {
            Assert.Equal(3.5, operation.Calculator('/', 7.0, 2));
        }
        [Fact]
        public void ShouldReturn0WhenOperatorIsNotCorrect()
        {
            Assert.Equal(0, operation.Calculator('^', 7, 2));
        }
        //Result Tests 

        [Fact]
        public void ShouldReturnSameNumberWhenExpressionIsOneNumberInLength()
        {

            Assert.Equal(23, operation.Result("23"));
        }

        [Fact]
        public void ShouldCalculateTwoNumberExpression()
        {

            Assert.Equal(5, operation.Result("+ 2 3"));
        }

        [Fact]
        public void ShouldCalculateFiveNumbersExpression()
        {

            Assert.Equal(17, operation.Result("- + * 2 3 * 5 4 9"));
        }
    }
}
