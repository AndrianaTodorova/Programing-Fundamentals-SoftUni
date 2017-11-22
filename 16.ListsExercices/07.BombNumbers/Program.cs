using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> someList = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse).ToList();

            int[] bomb = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int startIndex = someList.IndexOf(bomb[0]);

            while (startIndex != -1)
            {
                int beginIndex = Math.Max(0, startIndex - bomb[1]);
                int endIndex = Math.Min(someList.Count - 1, startIndex + bomb[1]);

                someList.RemoveRange(beginIndex, endIndex - beginIndex + 1);
                startIndex = someList.IndexOf(bomb[0]);
            }

            Console.WriteLine(someList.Sum());

        }
    }
}
