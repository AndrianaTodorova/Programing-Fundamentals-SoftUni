using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DrawAFilledSquare
{
    class DrawAFilledSquare
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeader(n);
            for (int i = 1; i <= n - 2; i++)
            {
                PrintMiddle(n);
            }
            PrintHeader(n);
        }
        static void PrintHeader(int n)
        {
            Console.WriteLine(new string ('-', 2 * n));
        }
        static void PrintMiddle(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }
    }
}
