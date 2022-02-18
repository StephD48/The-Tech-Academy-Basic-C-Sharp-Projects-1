using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericParameters
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();//This instantiates an employee object with type string as its generic parameter
            employee.Things = new List<string>();//This assigns a list of string as the property value
            employee.Things.Add("Stephanie"); //This adds object type string as the property value of Things
            employee.Things.Add("John");
            employee.Things.Add("Chloe");
            employee.Things.Add("Scott");
            employee.Things.Add("Alexis");
            employee.Things.Add("Hayden");
            Employee<int> Id = new Employee<int>();//This instantiates an employee object with the type integer as its generic parameter
            Id.Things = new List<int>();//This assigns a list of integers as the property value
            Id.Things.Add(48);//This adds object type integer as the property value of Things
            Id.Things.Add(58);
            Id.Things.Add(3);
            Id.Things.Add(39);
            Id.Things.Add(19);
            Id.Things.Add(15);
            foreach (string i in employee.Things)//This creates a foreach loop that prints all the things in the string list
            {
                Console.WriteLine(i);//This is the output of the employee.Things list
            }
            foreach (int a in Id.Things)//This creates a foreach loop that prints all the things in the integer list
            {
                Console.WriteLine(a);//This is the output of the Id.Things list
            }
            Console.ReadLine();//This ends the program



                                                             

        }
    }
}
