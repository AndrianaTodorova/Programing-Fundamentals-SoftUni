using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14.FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetZeroes(number));
        }
        private static BigInteger CalcFactorial(int number)
        {
            BigInteger factorial = 1;

            while (number > 1)
            {
                factorial *= number;
                number--;
            }

            return factorial;
        }
        private static BigInteger GetZeroes(int  number)
        {
            int trailingZerosCount = 0;
            BigInteger numToCheck = CalcFactorial(number);

            while (numToCheck > 0)
            {
                BigInteger digitToCheck = numToCheck % 10;

                if (digitToCheck == 0)
                {
                    trailingZerosCount++;
                }
                else
                {
                    break;
                }

                numToCheck /= 10;
            }

            return trailingZerosCount;
        }
    }
}
