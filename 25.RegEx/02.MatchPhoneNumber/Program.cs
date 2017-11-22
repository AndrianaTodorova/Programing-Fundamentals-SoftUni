using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359(\s|-)2\1\d{3}\1\d{4}\b";
            string input = Console.ReadLine();
            string[] mathes = Regex.Matches(input, pattern)
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();

            
                Console.WriteLine(string.Join(", ", mathes));
            
        }
    }
}
