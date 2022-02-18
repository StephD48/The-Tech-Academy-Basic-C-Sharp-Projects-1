using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
			// This is a Daily Report Program
			Console.WriteLine("The Tech Academy"); //This prints the school name
			Console.WriteLine("Student Daily Report");//This prints the name of the form
			Console.WriteLine("What is your name?");//This asks the user to input their name
			string yourName = Console.ReadLine(); //This returns a string of the users name


			Console.WriteLine("What course are you on?"); //This asks the user to input course they are on
			string yourCourse = Console.ReadLine(); // This returns a string for the course user is on

			Console.WriteLine("What page are you on?"); //This ask the user to input what page they are on
			int pageNumber = Convert.ToInt32(Console.ReadLine());//This returns an integer for the page number

			Console.WriteLine("Do you need help with anything? Please answer true or false"); //This asks the user to answer the question by inputting either true or false
			bool input = Convert.ToBoolean(Console.ReadLine()); //This returns a boolean true/false answer from user

			Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics."); //This ask the user to input any positive experiences they had
			string positiveExperiences = Console.ReadLine(); //This returns a string of the users experiences

			Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific."); //This asks the user to input more feedback 
			string feedback = Console.ReadLine(); //This returns a string of the user feedback

			Console.WriteLine("How many hours did you study today?"); //This asks the user to input the number of hours they studied
			int hours = Convert.ToInt32(Console.ReadLine()); //This returns an int for hours studied

			Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
			Console.ReadLine(); //This is prints a response to user answering the questions

			//This is the end of the program
		}
	}
}
