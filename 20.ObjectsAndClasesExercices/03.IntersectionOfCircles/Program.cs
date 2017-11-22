using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.IntersectionOfCircles
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var secondLine = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
            var list = new List<int>();
           
            var firstCircle = new Circle(firstLine);

            var secondCircle = new Circle(secondLine);

            var result = Intersect(firstCircle, secondCircle);
            if (result)
            {
                Console.WriteLine("Yes");
            }

            else
            {
                Console.WriteLine("No");
            }

        }
        static bool Intersect(Circle c1, Circle c2)
        {
            int xResult = c1.Center.X - c2.Center.X;
            int yResult = c1.Center.Y - c2.Center.Y;
            

            double distance = Math.Sqrt(xResult * xResult + yResult * yResult);
            if (distance <= c1.Radius + c2.Radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class Circle
    {
        public Circle(int[] input)
        {
            Center = new Point(input[0], input[1]);
            Radius = input[2];
        }

        public Point Center { get; set; }
        public int Radius { get; set; }
    }
    public class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = Y;
        }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
