using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();//Instantiates dateTime
            dateTime = DateTime.Now;//This assigns the variable dateTime to equal the current date and time
            Console.WriteLine("The current date and time is: {0}", dateTime);//This prints the current date and time to the console
            Console.WriteLine("Please enter a number to see what time it will be in that number of hours:");//This asks user to input a number
            double inputHour = Convert.ToDouble(Console.ReadLine());//this converts the user intput to double which stores floating point numbers
            dateTime = dateTime.AddHours(inputHour);//This adds the hours add by the user input to the current date time
            Console.WriteLine("In {0} hours, it will be:", Convert.ToString(inputHour));//This prints the exact time it will be in the number of hours the user input
            Console.WriteLine(dateTime);//This prints the dateTime to the console
            Console.ReadLine();
        }
        
    }
}
