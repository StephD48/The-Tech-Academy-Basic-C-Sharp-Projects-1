using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            double number = Convert.ToInt32(Console.ReadLine());
            double multiplyNumber = number * 50.0;
            Console.WriteLine(number + " multiplied by 50.0 is " + multiplyNumber);
            Console.ReadLine();

            Console.WriteLine("Enter a number");
            double num1 = Convert.ToInt32(Console.ReadLine());
            double addNumber = num1 + 25.0;
            Console.WriteLine(num1 + " added to 25.0 is " + addNumber);
            Console.ReadLine();

            Console.WriteLine("Enter a number here");
            double num2 = Convert.ToInt32(Console.ReadLine());
            double divideNumber = num2 / 12.5;
            Console.WriteLine(num2 + " divided by 12.5 is " + divideNumber);
            Console.ReadLine();

            Console.WriteLine("Please enter a number");
            double num3 = Convert.ToInt32(Console.ReadLine());
            double remainder = num3 % 7;
            Console.WriteLine(num3 + " divided by 7 has a remainder of " + remainder);
            Console.ReadLine();




        }
    }
}
