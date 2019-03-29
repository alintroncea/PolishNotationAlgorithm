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
