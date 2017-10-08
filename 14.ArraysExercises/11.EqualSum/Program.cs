using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToArray();

            bool isEqualSumsFound = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int[] leftSide = numbers.Take(i).ToArray();
                int[] rightSide = numbers.Skip(i + 1).ToArray();

                if (leftSide.Sum() == rightSide.Sum())
                {
                    Console.WriteLine(i);
                    isEqualSumsFound = true;
                    break;
                }
            }

            if (!isEqualSumsFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
