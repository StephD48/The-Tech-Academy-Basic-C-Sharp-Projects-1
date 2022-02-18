using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()//This instantiates and initializes an employee object
            {                                 //with the first name "Sample" and the last name "Student'
                FirstName = "Sample",
                LastName = "Student"
            };
            employee.SayName();//This calls the superclass method SayName() on the employee object
            Console.ReadLine();//This ends the program
            
        }
        
    }
}
