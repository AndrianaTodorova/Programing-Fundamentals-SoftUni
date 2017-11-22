using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPointParts = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var firstPoint = new Point
            {
                X = firstPointParts[0],
                Y = firstPointParts[1]
            };

            var secondPointParts = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var secondPoint = new Point
            {
                X = secondPointParts[0],
                Y = secondPointParts[1]
            };

            var result = CalculateDistance(firstPoint, secondPoint);

            Console.WriteLine($"{result:f3}");
        }
        public static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            var difX = firstPoint.X - secondPoint.X;
            var difY = firstPoint.Y - secondPoint.Y;

            var powX = Math.Pow(difX, 2);
            var powY = Math.Pow(difY, 2);

            return Math.Sqrt(powX + powY);
         }
    }
}


