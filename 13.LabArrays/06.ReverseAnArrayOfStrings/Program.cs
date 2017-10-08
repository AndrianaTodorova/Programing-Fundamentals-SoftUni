using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReverseAnArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ",Console.ReadLine().Split(' ').Reverse()));
        }
    }
}
