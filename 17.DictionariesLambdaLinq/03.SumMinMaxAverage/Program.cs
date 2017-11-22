using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumMinMaxAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> someList = new List<int>();
            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                someList.Add(int.Parse(Console.ReadLine()));
            }

            //double sum = someList.Sum();
            //double min = someList.Min(e => e);
            //double max = someList.Max(e => e);
            //double average = someList.Average();

            Console.WriteLine($"Sum = {someList.Sum()}");
            Console.WriteLine($"Min = {someList.Min()}");
            Console.WriteLine($"Max = {someList.Max()}");
            Console.WriteLine($"Average = {someList.Average()}");
            
        }
    }
}
