using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
          


            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                int packageWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter package height:");
                int packageHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                int packageLength = Convert.ToInt32(Console.ReadLine());


                if ((packageWidth + packageHeight + packageLength) > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                }
                else
                {
                    int packageCost = packageWidth * packageHeight * packageLength;
                    decimal totalCost = packageCost * packageWeight / 100m;
                    Console.WriteLine("Your estimated total for shipping this package is: $ " + totalCost);
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();

                }
            }
        }
    }
}
