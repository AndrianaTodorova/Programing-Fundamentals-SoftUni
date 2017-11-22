using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string text = Console.ReadLine();
            string pattern = @"(?:^| )[A-Za-z0-9][A-Za-z0-9.\\-_]*+@[A-Za-z0-9\\-]+(\\.[A-Za-z]+)+";

            var patternToMatch = Regex.Matches(text, pattern);

            foreach (Match match in patternToMatch)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
