using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] sum = new int[numbers.Length];
            

            for (int i = 1; i <= k; i++)
            {
                int temp = numbers[numbers.Length - 1];
                for (int j = numbers.Length - 1; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];
                }
                numbers[0] = temp;
                for (int b = 0; b < numbers.Length; b++)
                {
                    sum[b] += numbers[b];
                }
               
            }
            Console.WriteLine(String.Join(" ", sum));
        }
    }
}
