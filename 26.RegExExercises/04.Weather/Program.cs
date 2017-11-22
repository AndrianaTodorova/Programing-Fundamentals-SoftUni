using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^.*?([A-Z]{2})(\d+.\d+)([^|]+)\|([a-zA-Z]*)$";
            string text = Console.ReadLine();
            Dictionary<string, Dictionary<double, string>> allNeeded = new Dictionary<string, Dictionary<double, string>>();

           // Dictionary<string, Dictionary<double, string>> allNeeded = new Dictionary<string, List<string>>();

            while (text != "end")
            {

                var match = Regex.Match(text, pattern);

                if (match.Success)
                {
                   var city =  match.Groups[1].Value;
                    var temperature = double.Parse(match.Groups[2].Value);
                    var weather = match.Groups[3].Value;
                    if (!allNeeded.ContainsKey(city))
                    {
                        allNeeded.Add(city, new Dictionary<double, string>());
                    }
                    if (!allNeeded[city].ContainsKey(temperature))
                    {
                        allNeeded[city].Add(temperature, weather);
                    }
                }



                text = Console.ReadLine();
            }
            foreach (var output in allNeeded.OrderBy(a => a.Value.Keys.Average()))
            {
               var biggestTemperature =  output.Value.OrderByDescending(e => e.Key).First();

                Console.WriteLine($"{output.Key} => {biggestTemperature.Key:f2} => {biggestTemperature.Value}");
            }



        }
    }
}
