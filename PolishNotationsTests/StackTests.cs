using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PolishNotationAlgorithm
{
    public class StackTests
    {
        Stack stack = new Stack();

        [Fact]
        public void ShouldReturnPullPushedNumberFromStack()
        {
            stack.Push(3);
            Assert.Equal(3, stack.Pull());
        }

        [Fact]
        public void ShouldPullPushedRealNumberFromStack()
        {
            stack.Push(2.5);
            Assert.Equal(2.5, stack.Pull());
        }

        [Fact]
        public void ShouldReturn0When_NoNumberInStack()
        {          
            Assert.Equal(0, stack.Pull());
        }
    }
}
