using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolishNotationAlgorithm
{
    public class Operation
    {
        private Stack stack = new Stack();
        private Calculator calculate = new Calculator();

        public double Result(string input)
        {

            string[] inputArray = input.Split();
            if (inputArray.Length > 1)
            {

                for (int i = inputArray.Length - 1; i >= 0; i--)
                {

                    if (!IsOperator(inputArray[i]))
                    {
                        stack.Push(Convert.ToDouble(inputArray[i]));
                    }
                    if (IsOperator(inputArray[i]))
                    {
                        double firstOperand = stack.Pull();
                        double secondOperand = stack.Pull();

                        double operation = calculate.GetResult(Convert.ToChar(inputArray[i]), firstOperand, secondOperand);
                        stack.Push(operation);
                    }
                }
                return stack.Pull();
            }
            else
            {
                return Convert.ToDouble(inputArray[0]);
            }

        }
        public bool IsOperator(string input)
        {
            if (Convert.ToChar(input) == '+' || Convert.ToChar(input) == '-' || Convert.ToChar(input) == '*' || Convert.ToChar(input) == '/')
            {
                return true;
            }
            return false;
        }
    }
}
