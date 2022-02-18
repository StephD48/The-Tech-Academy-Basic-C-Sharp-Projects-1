using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName = "Stephanie";
            string mName = "Lynn";
            string lName = "Drake";

            Console.WriteLine(fName +  mName +  lName);//Concatenated the 3 strings fName, mName and lName
            Console.ReadLine();

            string city = "Boston";
            city = city.ToUpper();// Converted string city to Uppercase
            Console.WriteLine(city);
            Console.ReadLine();

            StringBuilder builder = new StringBuilder(); // Creating a string Builder
            builder.Append("This is the beginning of a paragraph."); //This is teh first line in the paragraph
            builder.AppendLine();//THis appends the line
            builder.Append("This is the second line in the paragraph").AppendLine();//This adds a second line in the paragraph
            builder.Append("I am learning C# ").AppendLine();//This adds another line in the paragraph

            Console.WriteLine(builder);
            Console.ReadLine();
        }
    }
}
