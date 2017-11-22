using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.ExtractSentencesByKeyWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToMatch = Console.ReadLine();
            string[] text = Console.ReadLine()
                .Split(new[] { '.', '!', '?' },StringSplitOptions.None);
            string pattern = $@".*?\b{wordToMatch}\b.*";
            foreach (var sentence in text)
            {

                var patternToMatch = Regex.Match(sentence, pattern);

                if (patternToMatch.Success)
                {

                    Console.WriteLine(patternToMatch.Value.Trim());
                }

            }

           
        }
    }
}
