using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ConvertFromBase10ToBaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            int N = int.Parse(input[0]);
            int baseNumber = int.Parse(input[1]);
            int rem = 0;
            var builder = new StringBuilder();
            do
            {
                rem = baseNumber % N;
                builder.Insert(0, rem);
                baseNumber /= N;

            } while (baseNumber > 0);
            string resultStr = builder.ToString();
            Console.WriteLine(resultStr);
            



        }
    }
}
