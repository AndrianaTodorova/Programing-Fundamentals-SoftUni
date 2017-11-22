using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RectanglePosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = ReadRectangle();
            var second = ReadRectangle();
            Console.WriteLine(IsInside(first, second)
                ? "Inside"
                : "Not inside");


        }
        public static Rectangle ReadRectangle()
        {
            var input = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToArray();

            var rectangle = new Rectangle
            {
                Left = input[0],
                Top = input[1],
                Width = input[2],
                Height = input[3]
            };
            return rectangle;
        }

        public static bool IsInside(Rectangle first, Rectangle second)
        {
            var lestIsCorrect = first.Left >= second.Left;
            var rightIsCorrect = first.Right <= second.Right;
            var bottomIsCorrect = first.Bottom <= second.Bottom;
            var topIsCorrect = first.Top <= second.Top;

            return lestIsCorrect
                && rightIsCorrect
                && bottomIsCorrect
                && topIsCorrect;
        }
    }
    public class Rectangle
    {
        public int Left { get; set; }

        public int Top { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Bottom => Top + Height;
     

        public int Right => Left + Width;
    }
}
