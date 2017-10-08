﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.MasterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (IsPalindrome(i) && IsSumOfDigitsDivisibleBySeven(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsPalindrome(int num)
        {
            int n = num;
            int rev = 0;
            while (num > 0)
            {
                int dig = num % 10;
                rev = rev * 10 + dig;
                num = num / 10;
            }

            if (n == rev)
            {
                return true;
            }

            return false;
        }

        private static bool IsSumOfDigitsDivisibleBySeven(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }

            if (sum % 7 == 0)
            {
                return true;
            }

            return false;
        }

        private static bool ContainsEvenDigit(int num)
        {
            while (num > 0)
            {
                int digitToCheck = num % 10;

                if (digitToCheck % 2 == 0)
                {
                    return true;
                }

                num /= 10;
            }

            return false;
        }
    }
}
