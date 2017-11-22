using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split(' ');
            int split = int.Parse(elements[0]);
            int take = int.Parse(elements[1]);
            string text = Console.ReadLine();

            string pattern = $@"\|<(\w{{{split}}})(\w{{0,{take}}})";
            Regex patternsMatched = new Regex(pattern);
            MatchCollection patternMatch = patternsMatched.Matches(text);
            List<string> result = new List<string>();
           
            foreach (Match match in patternMatch)
            {
                result.Add(match.Groups[2].Value);
               
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
