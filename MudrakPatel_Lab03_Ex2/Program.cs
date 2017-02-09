//Mudrak Patel; 300878960; Lab03

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudrakPatel_Lab03_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<char> charactersList = new List<char>();
                Random randomGenerator = new Random();

                for (int index = 0; index < 12; index++)
                {
                    charactersList.Add(Convert.ToChar(randomGenerator.Next(65, 91)));
                }

                Console.WriteLine("Randomly generated characters:");
                foreach (var character in charactersList)
                {
                    Console.WriteLine("character: " + character);
                }

                var ascendingList = from character in charactersList
                                    orderby character ascending
                                    select character;
                var descendingList = from character in charactersList
                                     orderby character descending
                                     select character;
                var distinctList = (from character in charactersList
                                    orderby character ascending
                                    select character).Distinct();

                Console.WriteLine("---------------------------");
                Console.WriteLine("Characters sorted in ascending order: ");
                foreach (var character in ascendingList)
                {
                    Console.WriteLine("character: " + character);
                }
                Console.WriteLine("---------------------------");

                Console.WriteLine("Characters sorted in descending order: ");
                foreach (var character in descendingList)
                {
                    Console.WriteLine("character: " + character);
                }
                Console.WriteLine("---------------------------");

                Console.WriteLine("Characters sorted in distinct manner: ");
                foreach (var character in distinctList)
                {
                    Console.WriteLine("character: " + character);
                }
                Console.WriteLine("---------------------------");
            }
            catch (Exception exception)
            {
                Console.WriteLine("Anexception occurred\n"+exception.Message);
            }
        }
    }
}
