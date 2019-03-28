using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolishNotationAlgorithm
{
 public class Stack
    {
       
           private double[] numbersArray = new double[0];

            public void Push(double number)
            {
                Array.Resize(ref numbersArray, numbersArray.Length+1);
                numbersArray[numbersArray.Length - 1] = number;
             
            }

           public double Pull()
           {

            if (numbersArray.Length == 0)
            {
                return 0;
            }
            if (numbersArray.Length == 1)
                return numbersArray[numbersArray.Length-1];

           
              double numberToBeReturned = numbersArray[numbersArray.Length - 1];
              Array.Resize(ref numbersArray, numbersArray.Length - 1);

              return numberToBeReturned;
           }
    }
    }

