using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an OddFilter function that takes a list as a parameter,
            // and returns a new list with every odd element from the orignal list
            //List<int> oddElements = OddFilter(new List<int> { 1, 2, 3, 4, 5 });

            // In case of the example input above, the given PrintList function should print 1 3 5 

            List<int> input = new List<int>();
            Console.WriteLine("Enter a number: ");
            
            PrintList();

            private static List<int> OddFilter(List<int> list)
            {
                int i;
                i = int.Parse(Console.ReadLine());
                input.Add(i);
                List<int> oddElements = OddFilter(new List<int>());
                foreach (int number in input)
                {
                    if (number % 2 != 0)
                        oddElements.Add(number);
                }
                return oddElements;
            }

            private static void PrintList(List<int>);
            {
                foreach (int element in oddElements)
                {
                    Console.Write("{0} ", element);
                }
            }
        }
    }
}
