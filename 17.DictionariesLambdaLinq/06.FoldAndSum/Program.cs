using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var k = input.Length / 4;

            var leftPart = input.Take(k).Reverse().ToArray();

            var middlePart = input.Skip(k).Take(k * 2).ToArray();

            var rightPart = input.Reverse().Take(k).ToArray();

            var leftAndRight = leftPart.Concat(rightPart).ToArray();
            var result = leftAndRight.Zip(middlePart, (x, y) => x + y).ToList();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
