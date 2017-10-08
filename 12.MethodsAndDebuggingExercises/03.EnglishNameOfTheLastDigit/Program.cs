using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            Console.WriteLine(GetEnglishNameOfLastDigit(number));
        }

        public static string GetEnglishNameOfLastDigit(long number)
        {
            string[] zeroToNine = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string lastDigitEnglish = string.Empty;
            long lastDigit = Math.Abs(number % 10);

            lastDigitEnglish = zeroToNine[lastDigit];
            return lastDigitEnglish;
        }
    
    }
}
