using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int maxOfTwo = GetMax(first, second);
            int maxOfThree = Math.Max(maxOfTwo, third);
            Console.WriteLine(maxOfThree);

        }
        static int GetMax(int first, int second)
        {
            return Math.Max(first, second);
        }
    }
}
