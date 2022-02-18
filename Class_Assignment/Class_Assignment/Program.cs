using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number");//This asks the user to enter a number
            int i = Convert.ToInt32(Console.ReadLine());//This converts to integer
            int g;
            MathOps math = new MathOps();//This instantiates the class
            math.Division(i);//This is the ouptut of the math operation
            Console.ReadLine();

            math.Division(out g);//This is the output parameters
            Console.ReadLine();

            math.Multiply(out i, out g);//This is an example of overload 
            Console.ReadLine();

            Movies.details();//This calls the movie details
            Console.WriteLine("The movie title is : {0} ", Movies.Title);//This prints the movie title
            Console.WriteLine("The director of the movie is : {0} ", Movies.Director);//This prints the movie director
            Console.ReadLine();
        }
    }
}
