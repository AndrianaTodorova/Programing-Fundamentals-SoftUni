using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());

            if (a == 65 || a == 69 || a == 73 || a == 79 || a == 85 || a == 89 || a == 97 || a == 101 ||
                a == 105 || a == 111 || a == 117 || a == 121 || a == 129)
            {
                Console.WriteLine("vowel");
            }
            else if (a >= 48 && a <= 57)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
