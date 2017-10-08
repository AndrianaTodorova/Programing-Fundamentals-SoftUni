using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double heidht = double.Parse(Console.ReadLine());
            double volumeOfPyramid = (lenght * width * heidht) / 3;
            Console.WriteLine($"Pyramid Volume: {volumeOfPyramid:f2}");
        }
    }
}
