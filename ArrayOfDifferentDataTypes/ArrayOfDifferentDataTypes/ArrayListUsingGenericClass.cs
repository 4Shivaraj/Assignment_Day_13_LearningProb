using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListOfDifferentDataTypes
{
    public class ArrayListUsingGenericClass<T>
    {
        public T[] inputArray;
        public ArrayListUsingGenericClass(T[] inputArray)
        {
            this.inputArray = inputArray;
        }
        public void ToPrint()  //Generic Method
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("-----------------------------------");
        }
    }  
}
