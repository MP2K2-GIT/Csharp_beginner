using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator();
        }
        static void Calculator()
        {
            double re;
            Console.Write("Enter a number :");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter what your operator you want :");
            string op = Console.ReadLine();
            Console.Write("Enter another number :");
            double num2 = Convert.ToDouble(Console.ReadLine());
            switch (op)
            {
                case "+":
                    re = num1 + num2;
                    break;
                case "-":
                    re = num1 - num2;
                    break;
                case "*":
                    re = num1 * num2;
                    break;
                case "/":
                    re = num1 / num2;
                    break;
                default:
                    re = -1;
                    Console.WriteLine("Invalid Operator");
                    break;
            }
            Console.WriteLine("Result = " + re);
            Console.ReadKey();
        }
    }
}
