using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToList();

            int[] integers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            numbers = numbers.Take(integers[0]).Skip(integers[1]).ToList();

            if (numbers.IndexOf(integers[2]) != -1)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }

            //int[] threeElements = { 0, 1, 2 };
            //integers.Take(threeElements[0]);
            //integers.Take(threeElements[1]);
            
        }
    }
}
