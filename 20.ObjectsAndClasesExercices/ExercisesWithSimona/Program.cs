using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesWithSimona
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> IntList = new List<int>();
            ExampleClass exc = new ExampleClass(Console.ReadLine(), 
                int.Parse(Console.ReadLine()));
            exc.music.Add(1, "song1");
            exc.music.Add(2, "song2");
            exc.music.Add(3, "song3");

            Console.WriteLine(string.Join("", exc.getSongs()));
            Console.WriteLine(exc.greeting());
        }
    }
}
