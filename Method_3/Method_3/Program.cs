using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Parameters age = new Parameters();//This methos instantiates the class age

            Console.WriteLine("Please enter your age.");//This ask the user to inut their age
            int num1 = Convert.ToInt32(Console.ReadLine());//This diplays the users input 
            Console.WriteLine("Please enter you brother's age if you have a brother. If not please leave blank");//This asks the users to enter a second number if applicable
            string userInput = Console.ReadLine();//creates a string variable and get user input and store it in a variable

            if (userInput == "")//If the user does not enter a second number then run this code
            {
                Console.WriteLine("Your age divided 10 is : " + age.Ages(num1));//This is the result if only one number is inputted by the user
            }
            else
            {
                int num2 = Convert.ToInt32(userInput);//Else the second number is converted to an integer and then this code is run
                Console.WriteLine("Your age minus your brothers age divided 10 is: " + age.Ages(num1, num2));//This is the output if there are two numbers inputted by the user
            }
            Console.ReadLine();//End Program

        }
    }
}
