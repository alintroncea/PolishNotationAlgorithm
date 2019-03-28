using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace PolishNotationAlgorithm
{
   public class MainTests
    {
        Calculate calculate = new Calculate();
        Stack stack = new Stack();

        //IsOperator Tests
        [Fact]
        public void ShouldReturnTrueIf_ItsAddOperator()
        {
            
            Assert.True(Program.IsOperator("+"));
        }
        [Fact]
        public void ShouldReturnTrueIf_ItsSubtractOperator()
        {

            Assert.True(Program.IsOperator("-"));
        }
        [Fact]
        public void ShouldReturnTrueIf_ItsMultiplyOperator()
        {

            Assert.True(Program.IsOperator("*"));
        }
        [Fact]
        public void ShouldReturnTrueIf_ItsDivideOperator()
        {

            Assert.True(Program.IsOperator("/"));
        }
        [Fact]
        public void ShouldReturnFalseIf_ItsNotAValidOperator()
        {

            Assert.False(Program.IsOperator("!"));
        }
        //Result Tests

        [Fact]
        public void ShouldReturnSameNumberWhenExpressionIsOneNumberInLength()
        {

            Assert.Equal(23, Program.Result("23",stack,calculate));
        }

        [Fact]
        public void ShouldCalculateTwoNumberExpression()
        {

            Assert.Equal(5, Program.Result("+ 2 3", stack, calculate));
        }

        [Fact]
        public void ShouldCalculateFiveNumbersExpression()
        {

            Assert.Equal(17, Program.Result("- + * 2 3 * 5 4 9", stack, calculate));
        }
    }
}
