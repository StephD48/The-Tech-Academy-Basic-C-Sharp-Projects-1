using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
         static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()//This creates a list of employees and instantiates them to the list with first name, last name and ID
            {

                new Employee() { FirstName = "Joe", LastName = "Jones", ID = 1 },
                new Employee() { FirstName = "Tim", LastName = "Smith", ID = 2 },
                new Employee() { FirstName = "Sally", LastName = "Field", ID = 3 },
                new Employee() { FirstName = "Joe", LastName = "Harris", ID = 4 },
                new Employee() { FirstName = "Sue", LastName = "Phillips", ID = 5 },
                new Employee() { FirstName = "Chris", LastName = "Lane", ID = 6 },
                new Employee() { FirstName = "Joe", LastName = "Johnson", ID = 7 },
                new Employee() { FirstName = "Alexis", LastName = "Drake", ID = 8 },
                new Employee() { FirstName = "Hayden", LastName = "Lee", ID = 9 },
                new Employee() { FirstName = "Joe", LastName = "Williams", ID = 10 },
            };



            Console.WriteLine("This is a list of all the employees in the list with the first name Joe ");//This writes the message to the console 
            List<Employee> newEmployee  = new List<Employee>();//This creates a new list 
            foreach (Employee employee in employees)//Foreach loop for each employee in employees do this code
            {
                if (employee.FirstName == "Joe")//If the employee has a first name of Joe they are added to the new list
                {
                    newEmployee.Add(employee);//The employees added to the new list
                    employee.SayName();//This prints the employees names to the console with the first name Joe
                }
            }
            Console.WriteLine("This is a list of all the employees with the first name Joe");//This performs the same action above only by using the lambda expression
            List<Employee> joe = employees.Where(x => x.FirstName == "Joe").ToList();//Lambda expression to add employees named Joe to a new list
            foreach (Employee employee in newEmployee)//For each loop for employee in the new employee list do this
            {
                employee.SayName();//This prints the employees named Joe to the console
            }

            Console.WriteLine("This is a list of all emplyees with an ID number greater than 5");//This uses a lambda expression to get all the employees from the list with Id numbers greater than 5
            List<Employee> Id = employees.Where(x => x.ID > 5).ToList();//Lambda expression to add employees with Id numbers greater than 5 to the list
            foreach (Employee employee in Id)//The is a for each loop for every employee  in the this with an Id greater than 5 do this
            {
                employee.SayName();//This prints the names of the employees with the ID greater than 5
                employee.ShowID();//This prints the Id numbers of the employees with the Id number greater than 5
            }
            
            
            Console.ReadLine();//This ends the program

            



           



        }
    }
}
