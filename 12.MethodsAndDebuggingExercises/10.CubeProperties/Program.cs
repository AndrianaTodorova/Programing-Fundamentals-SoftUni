using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            if (parameter == "face")
            {
                Console.WriteLine($"{GetFace(side):f2}");
            }
            else if (parameter == "space")
            {
                Console.WriteLine($"{GetSpace(side):f2}");
            }
            else if (parameter == "volume")
            {
                Console.WriteLine($"{GetVolume(side):f2}");
            }
            else if (parameter == "area")
            {
                Console.WriteLine($"{GetArea(side):f2}");
            }
        }

        static double GetFace(double side)
        {
            double face = Math.Sqrt(2 * (side * side));
            return face;
        }

        static double GetSpace(double side)
        {
            double space = Math.Sqrt(3 * (side * side));
            return space;
        }

        static double GetVolume(double side)
        {
            double volume = (side * side * side);
            return volume;
        }

        static double GetArea(double side)
        {
            double area = 6 * (side * side);
            return area;
        }
    }
}
