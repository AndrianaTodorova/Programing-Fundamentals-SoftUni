using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());
            double oneKilometer = 1.60934;
            double result = miles * oneKilometer;

            Console.WriteLine($"{result:f2}");
        }
    }
}
