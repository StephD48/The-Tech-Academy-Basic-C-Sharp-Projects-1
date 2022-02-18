using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string schoolName  = "South High School";//This creates a constant variable
            Console.WriteLine("Welcome to {0} student directory!", schoolName);//This prints to the console adding the constant variable
            Console.WriteLine("Please enter your First Name.");//This asks the user to input their first name
            var firstName = Console.ReadLine();//This creates a variable first name
            Console.WriteLine("Please enter your Last Name.");//This asks the user to input their last name
            var lastName = Console.ReadLine();//This creates a variable last name

            
            Student students = new Student(firstName, lastName);//Instantiates the student class with students
            Console.WriteLine("You have entered the name {0} {1} into the South High Student directory.", students.fName, students.lName);//This prints the users input into the console
            Student newStudent = new Student("New");//This instantiates the student class with newStudent
            Console.WriteLine("{0} {1} is a new student in the Student Directory", newStudent.fName, newStudent.lName);//This prints the nw student to the directory 
            Console.ReadLine();
           
        }
    }
}
