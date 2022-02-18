using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    public class Employee
    {
        public string FirstName { get; set;  }//This is the First name property of the Employee class as a string
        public string LastName { get; set; }//This is the Last name property of the Employee class as a string
        public int ID { get; set; }//This is the Id  property of the Employee class as an integer

        public void SayName()//Declaring SayName() method
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);//This writes the first and last name to the console when method SayName() is called
        }
        public void ShowID()//Declaring ShowID() method
        {
            Console.WriteLine("ID: {0}", ID);//This writes the Id to the console when the method ShowID() is called
        }
    }
}
