using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Main
{
    class MathOperation
    {
        public int IntOperator(int i)//Method to take take in an integer
        {
            int result1 = i + 64;//This takes the integer and adds it to another interger to return an integer
            return result1;//result of the math operation
        }
        public int IntOperator(decimal i)//method to take in a decimal
        {
            decimal result1 = i - 72;//the operation of subtracting the decimal from the integer to result to an integer
            return Convert.ToInt32(result1);//return the decimal to an integer
        }
        public int IntOperator(string i)//method to take in a string
        {
            if (int.TryParse(i, out int InputInt))//If statement  try parsing through sting to convert to integer
            {
                int result1 = InputInt * 36;//this the is string value multiplied by the integer to return an integer if possible
                return result1;//return result of the operation if string can be converted to integer
            }
            else
            {
                return 0;//return 0 if cannot change string to integer
            }

            
        }
        
            
             
        

    }
}
