using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                var result = $"{input[i]} -> {input[i] - 'a'}";
               File.WriteAllLines("Output.txt", result);
            }
        }
    }
}
