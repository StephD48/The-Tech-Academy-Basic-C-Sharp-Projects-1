using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodAssignment
{
    public class Math//Created a class called math
    {
        public int Addition(int num1)//Creating an addition method
        {
            int result1 = num1 + 25;//This takes the user input and adds it to 25 to give the result1
            return result1;//This is the result of the two numbers added together
        }
        public int Subtraction(int num1)//Creating a subtraction method
        {
            int result2 = num1 - 60;//This takes the user input and subtracts it by 60 to give the result2
            return result2;//This is the result of the two numbers subtracted from each other

        }
        public int Multiply(int num1)//Creating a Multiplication method
        {
            int result3 = num1 * 125;//This takes the user input and multiplies it by 125 to give the result3
            return result3;//This is the result of the two numbers multiplied together
        }
    }
}
