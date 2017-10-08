using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] arrayOne = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
            char[] arrayTwo = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

            char[] firstArray = new char[0];
            char[] secondArray = new char[0];

            int shorterArray = Math.Min(arrayOne.Length, arrayTwo.Length);
            bool isArrayOneFirst = false;
            bool isArrayTwoFirst = false;

            for (int i = 0; i < shorterArray; i++)
            {
                if (arrayOne[i] < arrayTwo[i])
                {
                    isArrayOneFirst = true;
                    break;
                }
                if (arrayOne[i] > arrayTwo[i])
                {
                    isArrayTwoFirst = true;
                    break;
                }
            }

            if (isArrayOneFirst)
            {
                firstArray = arrayOne;
                secondArray = arrayTwo;
            }
            else if (isArrayTwoFirst)
            {
                firstArray = arrayTwo;
                secondArray = arrayOne;
            }
            else
            {
                firstArray = arrayOne;
                secondArray = arrayTwo;

                if (arrayOne.Length >= arrayTwo.Length)
                {
                    firstArray = arrayTwo;
                    secondArray = arrayOne;
                }
            }

            Console.WriteLine(String.Join("", firstArray));
            Console.WriteLine(String.Join("", secondArray));




        }
    }
}
