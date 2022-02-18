using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        public static void Main()
        {
            try//This is a try block to run the program 
            {
                Console.WriteLine("Please enter the current day of the week");//This asks the user to input the current day of the week
                string UserInput = Console.ReadLine();//This is the user input string
                DaysOfTheWeek userInput = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), UserInput);//This parses through the enum days of the week
                Console.WriteLine("Woohoo!");//This is the respone to the user entering the day of the week
                Console.ReadLine();
            }
            catch(Exception)//this is a catch exception block to catch if there is a error and let the user know
            {
                Console.WriteLine("Please enter the actual day of the week");//This will print to let the user know they entered an invaild 
            }
            finally
            {
                Console.ReadLine();//This ends the program
            }
        }
        public enum DaysOfTheWeek//This creates an enum for the days of the week
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
