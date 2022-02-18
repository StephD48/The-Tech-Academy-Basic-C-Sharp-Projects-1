using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperator
{
    public class Employee
    {
        public int Id { get; set; }//This sets the employee class property of Id
        public static bool operator ==(Employee a, Employee b)//This what runs if the boolean operators are equal
        {
            return a.Id == b.Id;//This returns true if the two Id numbers are the same
        }
        public static bool operator !=(Employee a, Employee b)//This is what runs if the boolean operator is not equal
        {
            return a.Id != b.Id;//This returns false if the two Id numbers are different
        }
        public override bool Equals(object obj)//This overrides the Equals object method, takes an object to compare with current instance
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()//This overrides the get hash code method
        {
            return base.GetHashCode();
        }

    }
}
