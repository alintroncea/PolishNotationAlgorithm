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
        private double result;

        public double Calculator(char op, double firstOperand, double secondOperand)
        {
            switch (op)
            {
                case '+':
                    result = firstOperand + secondOperand;
                    break;
                case '-':
                    result = firstOperand - secondOperand;
                    break;
                case '*':
                    result = firstOperand * secondOperand;
                    break;
                case '/':
                    result = firstOperand / secondOperand;
                    break;
                default:
                    return 0;
            }

            return result;
        }

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

                        double operation = Calculator(Convert.ToChar(inputArray[i]), firstOperand, secondOperand);
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
