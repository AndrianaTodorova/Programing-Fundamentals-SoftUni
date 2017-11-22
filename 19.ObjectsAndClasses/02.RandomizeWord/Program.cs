using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomizeWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(' ')
                .ToArray();
            Random words = new Random();
            for (int i = 0; i < text.Length; i++)
            {
                int index = words.Next(0, text.Length);
                string rem = text[index];
                int newIndex = words.Next(0, text.Length);
                text[index] = text[newIndex];
                text[newIndex] = rem;
            }
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
            }
        }
    }
}
