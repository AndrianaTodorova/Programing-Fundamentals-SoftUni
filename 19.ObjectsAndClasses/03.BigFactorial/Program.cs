using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace _03.BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorial = number;
            for (int i = number - 1; i >=1; i--)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
           
        }
    }
}
