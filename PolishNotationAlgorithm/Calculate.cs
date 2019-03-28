using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolishNotationAlgorithm
{
   public class Calculate
    {
       
       
        public double GetResult(char op, double firstOperand, double secondOperand)
        {
            double result;

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

    }
}

