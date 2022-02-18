using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    public class MathOps
    {
        public void Division(int userNum1)//Created a void method division
        {
            int value = userNum1 / 2;//This takes the user input and divides it by 2
            Console.WriteLine("Your number " + userNum1 + " divided by 2 equals: " + value);//This is the output to the display
            return;

        }
        public void Division(out int userNum1)//Created a method with output parameters
        {
            Console.WriteLine("Please enter a new number");//Asks the user to input a number
            userNum1 = Convert.ToInt32(Console.ReadLine());//Converts the input to an integer
            int value1 = userNum1 / 6;//This value of the user input divied by the number 6
            Console.WriteLine("Your number " + userNum1 + " divided by " + 6 + " equals: " + value1);//This the ouptut to the display
        }
        public void Multiply(out int userNum1, out int userNum2)//This created an overload method
        {
            Console.WriteLine("Please enter your first number");//This asks the user to enter their first number
            userNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your second number");//This asks the user to enter a second number
            userNum2 = Convert.ToInt32(Console.ReadLine());
            int value2 = userNum1 * userNum2;//This takes the value of the two input numbers and multiplies them
            Console.WriteLine("Your first number " + userNum1 + " multiplied by your second number " + userNum2 + " equals: " + value2);//This prints the value of the two numbers multiplied

        }
        
    }   
     
}
