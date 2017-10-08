using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CharecterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());

            int leftHealth = maximumHealth - currentHealth;
            int leftEnergy = maximumEnergy - currentEnergy;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Health: |{0}{1}|",
                new string ('|', currentHealth),
                new string ('.',leftHealth));
            Console.WriteLine("Energy: |{0}{1}|",
                new string ('|',currentEnergy),
                new string ('.',leftEnergy));
        }
    }
}
