using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ClosestTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var listOfPoints = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var points = Console.ReadLine()
                    .Split(' ')
                    .Select(double.Parse)
                    .ToArray();

                listOfPoints.Add(new Point
                {  
                    X = points[0],
                    Y = points[1]
                });
            }
            var minDistanceSoFar = double.MaxValue;
            Point firstPointMax = null;
            Point secondPointMax = null;

            

            for (int i = 0; i < listOfPoints.Count - 1; i++)
            {
                for (int j = i + 1; j < listOfPoints.Count; j++)
                {
                    var firstPoint = listOfPoints[i];
                    var secondPoint = listOfPoints[j];
                    var currentDistance = CalculateDistance(firstPoint, secondPoint);
                    if (currentDistance < minDistanceSoFar)
                    {
                        minDistanceSoFar = currentDistance;
                        firstPointMax = firstPoint;
                        secondPointMax = secondPoint;
                    }
                }
            }
            Console.WriteLine($"{minDistanceSoFar:f3}");
            Console.WriteLine($"({firstPointMax.X}, {firstPointMax.Y})");
            Console.WriteLine($"({secondPointMax.X}, {secondPointMax.Y})");

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
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        
    }
}
