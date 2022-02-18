using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{
    public abstract class Person//Created an abstract class Person
    {
        public string FirstName { get; set; }//This a a property of the Person class (first name)
        public string LastName { get; set; }//This is a property of the Person class (last name)

        public abstract void SayName();//This is a method for the class
        
           
        
    }
}
