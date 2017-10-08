using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondLine = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var len1 = firstLine.Length;
            var len2 = secondLine.Length;
            int maxOfArrayLenght = Math.Max(firstLine.Length, secondLine.Length);

            for (int i = 0; i < maxOfArrayLenght; i++)
            {
                Console.Write(firstLine[i % len1] + secondLine[i % len2] + " ");
            }

        }
    }
}
