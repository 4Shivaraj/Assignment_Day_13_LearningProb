// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Welcome to Learninig Problem of Array of different datatypes");
namespace ArrayListOfDifferentDataTypes
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArrayListOfDataTypes arrayListOfData = new ArrayListOfDataTypes();
            Console.WriteLine("Using Normal Method: ");
            arrayListOfData.PrintIntArray();
            arrayListOfData.PrintDoubleArray();
            arrayListOfData.PrintCharArray();
            //Intialising Array To print Array List using Generics
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7 };
            double[] doubleArray = { 1.2, 1.3, 1.4, 1.5 };
            char[] charArray = { 'A', 'B', 'C', 'D' };
            ArrayListWithGenerics arrayListWithGenerics = new ArrayListWithGenerics();

            //When you use generic class no need of declaring with generic method // Vice Versa
            Console.WriteLine("Using Generic Method: ");
            arrayListWithGenerics.ToprintGeneric<int>(intArray);
            arrayListWithGenerics.ToprintGeneric<double>(doubleArray);
            arrayListWithGenerics.ToprintGeneric<char>(charArray);

            Console.WriteLine("Using Generic Classes: ");
            new ArrayListUsingGenericClass<int>(intArray).ToPrint();
            new ArrayListUsingGenericClass<double>(doubleArray).ToPrint();
            new ArrayListUsingGenericClass<char>(charArray).ToPrint();
        }
    }
    
}
//UC-3
////Print Array of Different Data Types using Normal Method,Generic Method & Generic Class.

//Result
//Using Normal Method:
//1
//2
//3
//4
//5
//6
//7
//------------------------------------
//1.2
//1.3
//1.4
//1.5
//------------------------------------
//A
//B
//C
//D
//------------------------------------
//Using Generic Method:
//1
//2
//3
//4
//5
//6
//7
//---------------------------------- -
//1.2
//1.3
//1.4
//1.5
//---------------------------------- -
//A
//B
//C
//D
//-----------------------------------
//Using Generic Classes:
//1
//2
//3
//4
//5
//6
//7
//---------------------------------- -
//1.2
//1.3
//1.4
//1.5
//---------------------------------- -
//A
//B
//C
//D
//-----------------------------------