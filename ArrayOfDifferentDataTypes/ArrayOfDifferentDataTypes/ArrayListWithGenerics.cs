using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListOfDifferentDataTypes
{
    public class ArrayListWithGenerics
    {
        public void ToprintGeneric<T>(T[] inputArray)  //Generic Method
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("-----------------------------------");
        }
    }

}
