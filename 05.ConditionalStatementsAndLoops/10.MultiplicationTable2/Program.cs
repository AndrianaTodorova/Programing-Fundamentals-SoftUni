using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.MultiplicationTable2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiplyFrom = int.Parse(Console.ReadLine());
            int times = 0;
            int product = 0;
            for (int i = multiplyFrom; i <= 10; i++)
            {
                times = i;
                product = number * i;
                Console.WriteLine($"{number} X {times} = {product}");
               
            }
            if (multiplyFrom > 10)
            {
                Console.WriteLine($"{number} X {multiplyFrom} = {number * multiplyFrom}");
            }
        }
    }
}
