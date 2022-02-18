using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathComparisonOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //This a a program that compares incomes of two people
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
         

            // This is Person 1 hourly rate and hours worked input
            Console.WriteLine("Person 1");//This is Person 1 in program
            Console.WriteLine("Enter your Hourly Rate");// Person 1 enters their hourly rate
            string rateHourly1 = Console.ReadLine(); // Person 1 Hourly rate in string
            decimal rateHour1 = Convert.ToDecimal(rateHourly1);// Person 1 hourly rate converted to decimal
            Console.WriteLine("Enter your hours worked per week");//Person 1 enters their hours worked per week
            string workedHours1 = Console.ReadLine();//Person 1 Hours worked in string
            decimal workedHour1 = Convert.ToDecimal(workedHours1);//Person 1 Hours worked converted in to decimal
            Console.WriteLine();//Hourly rate and Hours worked by Person 1


            // This is Person 2 hourly rate and hours worked input
            Console.WriteLine("Person 2"); //This is Person 2 in program
            Console.WriteLine("Enter  your Hourly Rate");//Person 2 enters their hourly rate
            string rateHourly2 = Console.ReadLine();//Person 2 hourly rate in string
            decimal ratehour2 = Convert.ToDecimal(rateHourly2);//Person 2 hourly rate converted to decimal
            Console.WriteLine("Enter your hours worked per week");//Person 2 enters their hours worked per week
            string workedHours2 = Console.ReadLine();//Person 2 hours wworked in string
            decimal workedHour2 = Convert.ToDecimal(workedHours2);//Person 2 hours worked cinverted to decimal
            Console.WriteLine();//Hourly rate and Hours worked by Person 2


            //This is where the annual salaries are compared to see which person makes more money
            decimal annualSalary1 = rateHour1 * workedHour1 * 52m;//Person 1 hours worked, hourly rate multiplied by weeks in year
            Console.Write("Annual salary of Person 1 is  $" + annualSalary1 );//Person 1 annual salary
            Console.ReadLine();
            decimal annualSalary2 = ratehour2 * workedHour2 * 52m;//Person 2 hours worked, hourly rate multiplied by weeks in year
            Console.Write("Annual salary of Person 2 is  $" + annualSalary2);//Person 2 annual salary
            Console.ReadLine();
            bool isMore = annualSalary1 > annualSalary2;//Boolean  true/false on who makes more money per year
            Console.WriteLine("Does Person 1 make more money than Person 2? " + isMore);//The result of the true/false question
            Console.ReadLine();//The end of the program








        }
    }
}
