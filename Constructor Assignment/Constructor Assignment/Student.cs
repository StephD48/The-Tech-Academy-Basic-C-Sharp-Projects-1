using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    public class Student
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public Student(string name) : this(name, "lastName")
        {

        }
        public Student(string name, string lastName)
        {
            fName = name;
            lName = lastName;

        }
        
    }
}
