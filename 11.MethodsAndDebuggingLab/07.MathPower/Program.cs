using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = PrintRaiseToPower(num, power);
            Console.WriteLine(result);
        }

        static double PrintRaiseToPower(double num, double power)
        {
            return Math.Pow(num, power);
        }
    }
}
