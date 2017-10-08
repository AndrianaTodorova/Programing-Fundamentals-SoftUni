using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine()
                .Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string[] secondLine = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            

            int leftCount = FingMaxCommonItems(firstLine, secondLine);
            Array.Reverse(firstLine);
            secondLine = secondLine.Reverse().ToArray();
            int rightCount = FingMaxCommonItems(firstLine, secondLine);

           
            Console.WriteLine(Math.Max(leftCount,rightCount));
        }
        private static int FingMaxCommonItems(string[] firstArray,string[] secondArr)
        {
            int counter = 0;
            int minLength = Math.Min(firstArray.Length, secondArr.Length);
            for (int i = 0; i < minLength; i++)
            {
                if (firstArray[i] == secondArr[i])
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }
            return counter;
        }
    }
}
