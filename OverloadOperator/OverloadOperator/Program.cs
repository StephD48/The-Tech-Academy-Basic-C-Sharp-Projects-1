using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();//This instantiates Employee class with employee 1
            employee1.Id = 5848;//This is employee 1 object Id number
            Employee employee2 = new Employee();//This instantiates Employee class with employee 2
            employee2.Id = 5648;//This is employee 2 object Id number

            bool value = employee1 == employee2;//This overloads the operator so it checks if the two employee objects are equal by Id property 

            Console.WriteLine("Do the two employees have the same Id number? " + value );//This returns the value whether the two Ids are the same with either true or false
            Console.ReadLine();//This ends the program


        }
    }
}
