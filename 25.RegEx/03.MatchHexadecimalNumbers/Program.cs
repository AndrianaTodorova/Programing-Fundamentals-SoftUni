using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.MatchHexadecimalNumbers
{
    class Program
    {
        private static object regex;

        static void Main(string[] args)
        {
            string pattern = @"\b(0x)?[A-F0-9]+\b";
            string input = Console.ReadLine();

            string[] reg = Regex.Matches(input, pattern)
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(" ", reg));
        }
    }
}
