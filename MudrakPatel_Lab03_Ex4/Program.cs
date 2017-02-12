using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudrakPatel_Lab03_Ex4
{
    class Program
    {

        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            List<double> doubleList = new List<double>();
            for (int index = 0; index <= 12; index++)
            {
                intList.Add(index);
                doubleList.Add((double)index);
            }

            DisplayArray(intList.ToArray());
        }

        //Overloaded DisplayArray method
       public static void DisplayArray<Type>(Type[] inputCollectionObject)
        {
            Console.WriteLine("\nAll elements in the list:\n------------------------------------------");
            foreach (var element in inputCollectionObject)
            {
                Console.WriteLine("Element: {0:3}",element);
            }
            Console.WriteLine("-----------------------------------------------s");
        }

        public static void DisplayArray<Type>(Type[] inputCollectionObject, int highIndex, int lowIndex)
        {

        }
    }
}
