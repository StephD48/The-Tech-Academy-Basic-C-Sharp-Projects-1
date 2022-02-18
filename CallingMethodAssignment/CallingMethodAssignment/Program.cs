using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please pick  a number and we can do a little math together!");//This asks the user to input a number
            int userInput = Convert.ToInt32(Console.ReadLine());//This converts to an integer
            int return1; 
            int return2;
            int return3;

            Math number = new Math(); 

            return1 = number.Addition(userInput);//This gives the value to result1
            return2 = number.Subtraction(userInput);//This gives the value to result2
            return3 = number.Multiply(userInput);//This gives the value to result3

            Console.WriteLine("The number you picked added to 25 equals: " + return1);//This is the result of the two numbers added together printed to the console
            Console.WriteLine("The number you picked subtracted from 60 equals: " + return2);//This is the result of the two numbers subtracted printed to the console
            Console.WriteLine("The number you picked multiplied by 125 equals: " + return3);//Thia is the result of the two numbers multiplied printed to the console
            Console.WriteLine("Thanks for doing a little math with me!");//Thanks the user for playing the game
            Console.ReadLine();


        }
    }
}
