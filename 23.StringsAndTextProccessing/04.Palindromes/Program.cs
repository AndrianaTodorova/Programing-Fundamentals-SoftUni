using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                 .Split(new[] { " ", ",", ".", "?", "!" }, StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();
            List<string> palindromes = new List<string>();
            for (int i = 0; i < text.Length; i++)
            {
                string myString = text[i];
                bool palindrome = IfIsPalindrome(myString);
                if (palindrome)
                {
                    palindromes.Add(myString);
                }
               
            }
            palindromes = palindromes.Distinct().OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(", ", palindromes));
        }
        public static bool IfIsPalindrome(string text)
        {
            for (int i = 0; i < text.Length / 2; i++)
            {
                if (text[i] != text[text.Length - i - 1])
                    return false;
            }
            return true;
        }
    }
}
