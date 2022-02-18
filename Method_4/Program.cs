using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_4
{
    class Program
    {
        static void Main(string[] args)
        {
            VoidOperation operation = new VoidOperation();//This instantiates the Class
            Console.WriteLine("Please enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            operation.Multiply(16, 27);//This calls the method in the class passing in two numbers
            operation.Multiply(num1: num1, num2: 34) ;//This calls the method in the class specifying the parameters by name
            Console.ReadLine();
        }
    }
}
