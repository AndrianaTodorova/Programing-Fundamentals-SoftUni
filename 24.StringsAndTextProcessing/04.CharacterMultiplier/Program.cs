using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] value = Console.ReadLine().Split(' ');
            string firstWord = value[0];
            string secondWord = value[1];
           int minWord =  Math.Min(firstWord.Length, secondWord.Length);
            int sum = 0;
            for (int i = 0; i < minWord; i++)
            {
                sum += firstWord[i] * secondWord[i];
            }
            string result = firstWord.Length > secondWord.Length ? firstWord : secondWord;

            for (int i = minWord; i < result.Length; i++)
            {
                sum += result[i];
            }

            Console.WriteLine(sum);
            
        }
    }
}
