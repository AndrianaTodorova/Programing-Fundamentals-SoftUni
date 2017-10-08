using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int times = 0;
            int product = 0;

            for (int i = 1; i <= 10; i++)
            {
                times = i;
                product = number * times;
                Console.WriteLine($"{number} X {times} = {product}");

            }
        }
    }
}
