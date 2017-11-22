using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.MatchNumbers
{
    class Program
    {
        private static string[] regex;

        static void Main(string[] args)
        {
            string pattern = @"(?:^|(?<=\s))(?:\-)?\d+(?:\.\d+)?(?:(?=\s)|$)";
            string numbers = Console.ReadLine();

            var match = Regex.Matches(numbers, pattern);
            foreach (Match newMatch in match)
            {
                Console.Write(newMatch.Value + " ");
            }
        }
    }
}
