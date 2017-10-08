using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var hexadecimal = (Convert.ToString(number, 16)).ToUpper();
            var binary = Convert.ToString(number, 2);
            Console.WriteLine(hexadecimal);
            Console.WriteLine(binary);
        }
    }
}
