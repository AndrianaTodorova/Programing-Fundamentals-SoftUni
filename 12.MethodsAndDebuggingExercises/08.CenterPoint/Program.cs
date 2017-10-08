using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CenterPodouble
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine(GetClosestPodoubleToTheCenter(x1, y1, x2,  y2));
        }
        static string GetClosestPodoubleToTheCenter(double x1, double y1, double x2, double y2)
        {
            string closestPoint = String.Empty;
            double diagonal1 = Math.Sqrt((x1 * x1) + (y1 * y1));
            double diagonal2 = Math.Sqrt((x2 * x2) + (y2 * y2));
            if (diagonal1 > diagonal2)
            {
                closestPoint= $"({x2}, {y2})";
            }
            else
            {
                closestPoint = ($"({x1}, {y1})");
            }
            return closestPoint;
        }
    }
}
