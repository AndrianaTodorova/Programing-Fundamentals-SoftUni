using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            string timeLeaving = Console.ReadLine();
            DateTime timeLeavingFormatted = DateTime.ParseExact(timeLeaving, "HH:mm:ss", CultureInfo.InvariantCulture);

            double steps = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());

            double result = steps * timeInSeconds;
           DateTime timeArrival =  timeLeavingFormatted.AddSeconds((result));
            Console.WriteLine($"Time Arrival: {timeArrival.Hour:d2}:{timeArrival.Minute:d2}:{timeArrival.Second:d2}");
        }
    }
}
