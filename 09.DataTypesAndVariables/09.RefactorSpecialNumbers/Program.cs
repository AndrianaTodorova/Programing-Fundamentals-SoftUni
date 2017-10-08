using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {


            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int digit = 0;
            bool special = false;
            for (int currentDigit = 1; currentDigit <= number; currentDigit++)
            {
                sum = 0;
                currentDigit = digit;
                digit = currentDigit;
                while (currentDigit > 0)
                {
                    sum += currentDigit % 10;
                    currentDigit = currentDigit / 10;
                }
                special = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{digit} -> {special}");
               

            }
        }    }
}
