using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AppendList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> result = new List<int>();
            string[] append = Console.ReadLine()
                .Split('|')
                .ToArray();

            for (int i = append.Length; i > 0; i--)
            {

                int[] temp = append[i - 1]
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                result.AddRange(temp);
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
