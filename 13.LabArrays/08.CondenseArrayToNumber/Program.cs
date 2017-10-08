using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int condensted = number.Length ;

            do
            {
                for (int i = 0; i < condensted - 1; i++)
                {
                    number[i] = number[i] + number[i + 1];
                }
                condensted--;
            } while (condensted > 0);
            Console.WriteLine(number[0]);
        }
    }
}
