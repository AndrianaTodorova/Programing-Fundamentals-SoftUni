using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            ushort time = (ushort)(hours * 3600 + minutes * 60 + seconds);
            float metersPerSec = (float)distanceInMeters / time;
            float kilometersPerHour = ((float)distanceInMeters / 1000) / ((float)time / 3600);
            float milesPerHour = ((float)distanceInMeters / 1609) / ((float)time / 3600);
            Console.WriteLine("{0:0.#######}", metersPerSec);
        Console.WriteLine("{0:0.#######}", kilometersPerHour);
        Console.WriteLine("{0:0.#######}", milesPerHour);

        }
    }
}
