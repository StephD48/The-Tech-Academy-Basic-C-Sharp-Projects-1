using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();//This instantiates the Employee object 
            employee.FirstName = "Sample";//This is an object in the class called first name
            employee.LastName = "Student";//This is an object in the class called last name
            employee.SayName();//This calls the superclass method SayName() on the employee class
            IQuittable quit = new Employee();//This uses polymorphism to create an object type IQuittable 
            quit.Quit();//This calls the quit method
            Console.ReadLine();//Ends the program
            
        }
    }
}
