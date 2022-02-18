using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Main
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation Math = new MathOperation();//Instantiating the class

            Console.WriteLine(Math.IntOperator(56));//Calling the method to return result of math (addition) operation to the screen
            Console.WriteLine(Math.IntOperator(15.8m));//Calling the method to return the result of the math (decimal to integer by subtration) operation to the screen
            Console.WriteLine(Math.IntOperator("hello"));//Calling the method to return the result of the operation to convert a string to an integer 
            Console.ReadLine();


        }
    }
}
