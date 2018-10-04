using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the operation");
            char oper = Convert.ToChar(Console.ReadLine());

            int result;

            switch (oper)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("Result = " + result);
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine("Result = " + result);
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine("Result = " + result);
                    break;
                case '/':
                    result = num1 / num2;
                    Console.WriteLine("Result = " + result);
                    break;
                
            }
        }
    }
}
