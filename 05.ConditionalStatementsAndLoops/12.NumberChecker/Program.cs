using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (System.Exception)
            {
                Console.WriteLine("Invalid input!");
                
            }
        }
    }
}
