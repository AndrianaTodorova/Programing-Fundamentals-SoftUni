using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.VariableinHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexadecimalNumber = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(hexadecimalNumber, 16));
        }
    }
}
