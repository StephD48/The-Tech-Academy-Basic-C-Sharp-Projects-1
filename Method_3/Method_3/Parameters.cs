using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_3
{
    class Parameters
    {
     public int Ages(int num1, int num2 = 0)//This method takes two integers as paramenters with num2 being optional
        {
            int results = (num1 - num2) / 10;//This is the result of the equaation if both parameters are used
            return results;//This is the result displayed
        }
    }
}
