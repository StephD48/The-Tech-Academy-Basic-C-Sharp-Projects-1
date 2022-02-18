using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{
    public class Employee : Person, IQuittable//This is the class Employee that inherits the Person class and IQuittable interface
    {
        public int Id { get; set; }//This is a property of the Employee class with the integer data type
        public override void SayName()//This implements the SayName method
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);//The output of the SayName method when it is implemented
        }
        public void Quit()//Implementing quit method
        {
            Console.WriteLine("To quit press enter!!");//Messagage to the user
        }
        
        

    }
}
