using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._4.SieveofEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool[] array = new bool[number + 1];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = true;
            }
            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if (array[i])
                {
                    for (int j = i * i; j <= number; j+=i)
                    {
                        array[j] = false;
                    }
                }
            }
            int[] primes = new int[number + 1];

            for (int i = 2; i < primes.Length; i++)
            {
                if (array[i])
                {
                    primes[i] = i;
                }
            }
            primes = primes.Except(new int[]  { 0 } ).ToArray();
            Console.WriteLine(string.Join(" ", primes));
        }
    }
}
