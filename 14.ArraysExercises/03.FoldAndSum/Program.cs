using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int k = firstArr.Length / 4;

            int[] leftArr = firstArr.Take(k).ToArray();
            int[] midArr = firstArr.Skip(k).Take(k * 2).ToArray();
            int[] rightArr = firstArr.Skip(k * 3).Take(k).ToArray();

            Array.Reverse(leftArr);
            Array.Reverse(rightArr);

            int[] result = new int[k * 2];
            for (int i = 0; i < k; i++)
            {
                result[i] = midArr[i] + leftArr[i];
                result[i + k] = midArr[i + k] + rightArr[i];
            }
            Console.WriteLine($"{String.Join(" ",result)}");
        }
    }
}
