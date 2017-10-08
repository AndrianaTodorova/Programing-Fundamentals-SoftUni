using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int currentDigit = 0;
            int currentLength = 1;

            int besDigit = 0;
            int bestLength = 0;

            for (int i = 1; i < number.Length ; i++)
            {
                if (number[i] > number[i - 1])
                {
                    currentLength++;
                    if (currentLength > bestLength)
                    {
                        besDigit = currentDigit;
                        bestLength = currentLength;
                    }
                }
                else
                {
                    currentDigit = i;
                    currentLength = 1;
                }
               
            }
            for (int i = besDigit; i < besDigit + bestLength; i++)
            {
                Console.Write(number[i] + " ");
            }
        }
    }
}
