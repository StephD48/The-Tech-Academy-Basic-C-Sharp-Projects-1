using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    public class Person//Created the Person class
    {
        public string FirstName { get; set; }//This a string property in the person class called FirstName
        public string LastName { get; set; }//This is a string property in the person class called LastName 

        public void SayName()//This is a void method that has no parameters 
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);//The Name: full name is written in the console
        }
    }
}
