using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericParameters
{
    public class Employee<T>//Created a class called Employee and it has a generic type parameter
    {
        public List<T> Things { get; set; } //This is the property of the employee class called Things, it's
                                            // data type is a generic list 
    }
}
