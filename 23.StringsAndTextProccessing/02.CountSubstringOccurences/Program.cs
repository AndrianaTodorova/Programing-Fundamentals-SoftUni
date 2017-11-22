using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CountSubstringOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string badWords = Console.ReadLine().ToLower();
            int counter = 0;
            int index = text.IndexOf(badWords);

            while (index != -1)
            {
                counter++;
                index = text.IndexOf(badWords, index + 1);
            }

            Console.WriteLine(counter);
        }
    }
}
