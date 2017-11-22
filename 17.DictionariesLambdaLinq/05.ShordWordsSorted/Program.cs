using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ShordWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayOfWords = Console.ReadLine()
                .ToLower()
                .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .Distinct()
                .ToArray();

            Console.WriteLine(string.Join(", ", arrayOfWords));
            
        }
    }
}
