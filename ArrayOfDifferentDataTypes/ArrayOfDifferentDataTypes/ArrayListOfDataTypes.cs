using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListOfDifferentDataTypes
{
    public class ArrayListOfDataTypes
    {
        int[] intArray = { 1, 2, 3, 4, 5, 6, 7 }; 
        public void PrintIntArray()
        {
            foreach (var element in intArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("------------------------------------");
        }

        double[] doubleArray = { 1.2, 1.3, 1.4, 1.5 };
        public void PrintDoubleArray()
        {
            foreach (var element in doubleArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("------------------------------------");
        }

        char [] charArray = { 'A', 'B', 'C', 'D'};
        public void PrintCharArray()
        {
            foreach (var element in charArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("------------------------------------");
        }

    }
}
