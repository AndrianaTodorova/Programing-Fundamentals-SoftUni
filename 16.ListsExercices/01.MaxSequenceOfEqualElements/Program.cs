using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int maxCount = 0;
            int index = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentCount = 0;
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        currentCount++;
                        if (currentCount > maxCount)
                        {
                            maxCount = currentCount;
                            index = i;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }


            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(numbers[i + index] + " ");
            }



            //int startIndex = 0;
            //int sequenceLength = 1;

            //int bestStarIndex = 0;
            //int bestSequenceLength = 1;

            //for (int i = 1; i < integers.Count; i++)
            //{
            //    if (integers[i] == integers[i-1])
            //    {
            //        sequenceLength++;
            //        if (sequenceLength > bestSequenceLength)
            //        {
            //            bestStarIndex = startIndex;
            //            bestSequenceLength = sequenceLength;
            //        }
            //    }
            //    else
            //    {
            //        startIndex = i;
            //        sequenceLength = 1;
            //    }
            //}
            //for (int i = bestStarIndex; i < bestStarIndex + bestSequenceLength; i++)
            //{
            //    Console.Write(integers[i] + " ");
            //}


        }
    }
}
