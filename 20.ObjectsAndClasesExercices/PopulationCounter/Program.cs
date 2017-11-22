using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> countriesAndCities = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input != "report")
            {
                string[] countriesAndPopulation = input
                    .Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                bool containsCountry = countriesAndCities.Keys.Contains(countriesAndPopulation[1]);
                if (!containsCountry)
                {
                    Dictionary<string, int> cityAndPopulation = new Dictionary<string, int>();
                    cityAndPopulation.Add(countriesAndPopulation[0], int.Parse(countriesAndPopulation[2]));
                    countriesAndCities.Add(countriesAndPopulation[1], new Dictionary<string,int>());
             
                }

                input = Console.ReadLine();
            }
        }
    }
}
