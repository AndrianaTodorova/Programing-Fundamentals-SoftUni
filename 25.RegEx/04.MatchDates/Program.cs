using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.MatchDates
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string pattern = @"\b((\d{2})(\/|\.|-)([A-Z][a-z]{2})\3(\d{4}))\b";
            string input = Console.ReadLine();

            MatchCollection regex = Regex.Matches(input, pattern);

            foreach (Match item in regex)
            {
                string d = item.Groups[2].Value;
                string m = item.Groups[4].Value;
                string y = item.Groups[5].Value;
                Console.Write("Day: " + d + ", ");
                Console.Write("Month: " + m + ", ");
                Console.WriteLine("Year: " + y);
            }

            

        }
    }
}
