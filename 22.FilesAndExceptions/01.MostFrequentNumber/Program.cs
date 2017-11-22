using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Input.txt";
            var numbers = File.ReadAllLines(input).Split(' ').Select(int.Parse)
              .ToArray();

            int frequentDigit = 0;
            int longestStreak = 0;


            for (int i = 0; i < numbers.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] == numbers[i])
                    {
                        counter++;
                    }
                }
                if (counter > longestStreak)
                {
                    longestStreak = counter;
                    frequentDigit = int.Parse(numbers[i]);
                }
            }
            
            File.WriteAllText("Output.txt", frequentDigit.ToString());
            
        }
    }
}
