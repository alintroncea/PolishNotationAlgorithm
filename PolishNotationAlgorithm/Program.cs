using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolishNotationAlgorithm
{
   public class Program
    {

        static void Main(string[] args)
        {
            Operation operation = new Operation();

            string input = Console.ReadLine();
            Console.Write(operation.Result(input));
            Console.Read();
        }
     
    }
}
