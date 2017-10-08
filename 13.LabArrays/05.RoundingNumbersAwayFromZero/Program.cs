using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RoundingNumbersAwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] number = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] rounded = new int[number.Length];
            for (int i = 0; i < number.Length; i++)
            {
                rounded[i] = (int)Math.Round(number[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{number[i]} -> {rounded[i]}");
            }
        }
    }
}
