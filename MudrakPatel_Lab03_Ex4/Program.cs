using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudrakPatel_Lab03_Ex4
{
    class Program
    {
        static List<int> intList = new List<int>();
        static List<double> doubleList = new List<double>();

        static void Main(string[] args)
        {
            try
            {
                for (int intIndex = 0; intIndex <= 100; intIndex++)
                {
                    intList[intIndex] = intIndex;
                    for (double doubleIndex = 0.0; doubleIndex <= 100.00; doubleIndex++)
                    {
                        doubleList[(int)doubleIndex] = doubleIndex;
                    }
                }

                Program.DisplayArray(intList, 2, 10);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //Overloaded DisplayArray method
        public static void DisplayArray<Type>(List<Type> inputList, int lowIndex, int highIndex)
        {
            var selectedElements = inputList.GetRange(lowIndex,highIndex);
            foreach (var element in selectedElements)
            {
                Console.WriteLine("\n"+element);
            }
        }
    }
}
