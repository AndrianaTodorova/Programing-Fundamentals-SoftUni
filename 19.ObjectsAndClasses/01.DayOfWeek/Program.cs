using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
             DateTime formatedDate = DateTime.ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(formatedDate.DayOfWeek);
        }
    }
}
