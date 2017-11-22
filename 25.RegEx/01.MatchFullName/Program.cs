using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+\s[A-Z][a-z]+\b";

           MatchCollection regex =  Regex.Matches(text, pattern);
            foreach (Match name in regex)
            {
                Console.Write(name.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
