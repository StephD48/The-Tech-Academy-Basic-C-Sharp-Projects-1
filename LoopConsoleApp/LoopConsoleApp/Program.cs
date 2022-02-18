using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my favorite color?");
            string color = Console.ReadLine();
            bool isGuessed = color == "red";

            do
            {
                switch (color)
                {
                    case "green":
                        Console.WriteLine("You guessed green. Sorry, try again.");
                        Console.WriteLine("Guess a color?");
                        color = Console.ReadLine();
                        break;
                    case "orange":
                        Console.WriteLine("You guessed orange. Nope, try again.");
                        Console.WriteLine("Guess a color?");
                        color = Console.ReadLine();
                        break;
                    case "purple":
                        Console.WriteLine("You guessed purple. Keep trying.");
                        Console.WriteLine("Guess a color?");
                        color = Console.ReadLine();
                        break;
                    case "red":
                        Console.WriteLine("You guessed the color red.That is the correct color!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a color?");
                        color = Console.ReadLine();
                        break;
                }
            }
            while (!isGuessed);

            Console.ReadLine();

            Console.WriteLine("Guess my favorite football team?");
            string team = Console.ReadLine();
            bool isRight = team == "New England Patriots";

            while (!isRight)
            {
                switch (team)
                {
                    case "Kansas City Chiefs ":
                        Console.WriteLine("You guessed Kansas City Chiefs. Sorry, try again.");
                        Console.WriteLine("Guess a team?");
                        team = Console.ReadLine();
                        break;
                    case "Buffalo Bills":
                        Console.WriteLine("You guessed Buffalo Bills. Nope, try again.");
                        Console.WriteLine("Guess a team?");
                        team = Console.ReadLine();
                        break;
                    case "Atlanta Falcons":
                        Console.WriteLine("You guessed Atlanta Falcons. Keep trying.");
                        Console.WriteLine("Guess a team?");
                        team = Console.ReadLine();
                        break;
                    case "New England Patriots":
                        Console.WriteLine("You guessed the New England Patriots! That is the correct football team!");
                        isRight = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a team?");
                        team = Console.ReadLine();
                        break;
                }
            }
            Console.ReadLine();



        }
    }
}
