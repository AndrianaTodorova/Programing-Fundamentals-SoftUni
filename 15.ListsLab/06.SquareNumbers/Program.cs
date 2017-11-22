using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> sqrtNums = new List<int>();

            foreach(var number in numbers)
            { 
                if (Math.Sqrt (number) == (int)Math.Sqrt(number))
                {
                    sqrtNums.Add(number);
                }
            }
            sqrtNums.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", sqrtNums));
            
        }
    }
}
