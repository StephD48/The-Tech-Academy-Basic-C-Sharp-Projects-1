using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Number number = new Number();//This instantiates the number class
            number.Amount = 3.5m;//Created a object of data type number assigning it a decimal amount 
            Console.WriteLine(number.Amount);//This prints the amount to the console
            Console.ReadLine();//This ends the program
        }
    }
}
