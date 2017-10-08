using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxSequenceofEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int startIndex = 0;
            int sequenceLength = 1;

            int bestStarIndex = 0;
            int bestSequenceLength = 0;
            for (int i = 1; i < numbers.Length; i++)
            {

                if (numbers [i] == numbers [i - 1])
                {
                    sequenceLength++;
                    if (sequenceLength > bestSequenceLength)
                    {
                        bestStarIndex = startIndex;
                        bestSequenceLength = sequenceLength;
                    }
                }
                else
                {
                    startIndex = i;
                    sequenceLength = 1;
                }
            }
            for (int i = bestStarIndex; i < bestStarIndex + bestSequenceLength; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
