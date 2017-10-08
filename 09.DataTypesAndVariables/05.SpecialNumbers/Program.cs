using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());


            for (int i = 1; i <= num; i++)
            {
                int sumOfDigits = 0;
                int digits = i;

                while (digits > 0)
                {
                    int currentDigit = digits % 10;
                    digits = digits / 10;
                    sumOfDigits += currentDigit;
                }
                bool result = sumOfDigits == 5 ||
                              sumOfDigits == 7 ||
                              sumOfDigits == 11;
                Console.WriteLine(i + "->" + result);
            }
        }
    }
}

