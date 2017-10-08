using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };
            int dayNums = int.Parse(Console.ReadLine());
            if (dayNums >= 1 && dayNums <= 7)
            {
                Console.WriteLine((days[dayNums - 1]));
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
