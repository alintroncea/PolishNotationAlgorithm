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

        private char op;
        private double firstOperand;
        private double secondOperand;

        public void Calculator(char op, double firstOperand, double secondOperand)
        {
            this.op = op;
            this.firstOperand = firstOperand;
            this.secondOperand = secondOperand;

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
                    result = 0;
                    break;
            }

            stack.Push(result);
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

                        Calculator(Convert.ToChar(inputArray[i]), firstOperand, secondOperand);
                      
                    }
                }
                return stack.Pull();
            }
            else
            {
                return Convert.ToDouble(inputArray[0]);
            }

        }

        private string input;
        public bool IsOperator(string input)
        {
            this.input = input;
            if (Convert.ToChar(input) == '+' || Convert.ToChar(input) == '-' || Convert.ToChar(input) == '*' || Convert.ToChar(input) == '/')
            {
                return true;
            }
            return false;
        }
    }
}
