using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LastKNumbersSumsSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            // var nums = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] sequence = new int[n];
            sequence[0] = 1;
            Console.WriteLine(sequence[0]);
            for (int i = 1; i < n; i++)
            {
                sequence[i] = 0;
                for (int j = 1; j <= k && i-j>=0; j++)
                {
                    sequence[i] += sequence[i-j];
                }
                Console.WriteLine(sequence[i]);
            }
        }
    }
}
