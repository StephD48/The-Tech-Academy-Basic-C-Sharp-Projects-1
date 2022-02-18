using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIntegerAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();// Creating a list of integers
            numbers.Add(34);//Adding elements to the list numbers
            numbers.Add(75);
            numbers.Add(98);
            numbers.Add(100);
            numbers.Add(250);
            numbers.Add(15);

            try//Try this code
            {

                Console.WriteLine("Please pick a number");//This asks the user to pick a number
                int inputNumber = Convert.ToInt32(Console.ReadLine());//This converts to integer
                foreach (int number in numbers)//This states for each number in the list numbers do the following
                {
                    int q = number / inputNumber;//This names q as the value of a number in the list divided by the user input number
                    Console.WriteLine(number + " divided by " + inputNumber + " equals " + q);//This displays the results of all the list numbers
                                                                                              //divided by the user input number
                }
            }
            catch (DivideByZeroException ex)//Catch if the user enters the number 0
            {
                Console.WriteLine("Please dont not enter the number 0");//What is displayed to the use if they input 0
            }
            catch (Exception ex)//Catch if the user enters a string not a number
            {
                Console.WriteLine("Please enter a whole number");//What is displayed to the user if they enter a string
            }
            finally//The finally block releases the resources from the system. It always executes
            {
                Console.WriteLine("Yay! You did it!");//This displays at the end of the executed code.
            }
            Console.ReadLine();







        }
    }
}
