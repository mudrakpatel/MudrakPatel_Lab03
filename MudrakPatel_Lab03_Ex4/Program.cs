using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudrakPatel_Lab03_Ex4
{
    class Program
    {
        static int[] intArray = { };
        static double[] doubleArray = { };

        static void Main(string[] args)
        {
            for (int intIndex = 0; intIndex<=100; intIndex++)
            {
                intArray[intIndex] = intIndex;
                for (double doubleIndex = 0.0; doubleIndex<=100.00; doubleIndex++)
                {
                    doubleArray[(int)doubleIndex] = doubleIndex;
                }
            }

            intArray.ToList();
            doubleArray.ToList();
        }

        //Overloaded DisplayArray method
        public static void DisplayArray<Type>(Type[] inputArray, int lowIndex, int highIndex)
        {

        }
    }
}
