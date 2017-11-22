using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddOcurences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();
            var words = input.Split(' ');
            

            var counts = new Dictionary<string, int>();
            foreach (var word in words)
            {
                counts[word] = 0;
            }
            foreach (var word in words)
            {
                counts[word]++;
            }
            List<string> uniqueWords = new List<string>();
            foreach (var item in counts)
            {
                if (item.Value % 2 != 0)
                {
                    uniqueWords.Add(item.Key);
                }
            }
            Console.WriteLine(String.Join(", ", uniqueWords));
        }
    }
}
