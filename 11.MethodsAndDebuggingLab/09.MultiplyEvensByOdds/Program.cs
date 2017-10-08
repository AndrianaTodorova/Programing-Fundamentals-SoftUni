using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num =Math.Abs( int.Parse(Console.ReadLine()));
            int result = Math.Abs(GetMultipleOfOddsAndEvens(num));
            Console.WriteLine(result);
        }

        private static int GetMultipleOfOddsAndEvens(int num)
        {
            int sumEvens = GetSumOfEvenDigits(num);
            int sumOdds = GetSumOfOddDigits(num);
            return sumEvens * sumOdds;
        }
        private static int GetSumOfOddDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                num /= 10;
            }
            return sum;
        }

        private static int GetSumOfEvenDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                num /= 10;
            }
            return sum;
        }
    }
}
