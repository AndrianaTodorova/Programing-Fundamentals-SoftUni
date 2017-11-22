using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] drivers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            double[] zones = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            int[] indexes = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Select(x => Math.Abs(x))
                .ToArray();

           
            for (int i = 0; i < drivers.Length ; i++)
            {
                string firstWord = drivers[i].ToString();
                double firstWordNumber = firstWord[0];
                int checkPointsCounter = 0;

                for (int j = 0; j < zones.Length; j++)
                {
                    bool isEqual = false;
                    for (int k = 0; k < indexes.Length; k++)
                    {
                        if (j == indexes[k])
                        {
                            isEqual = true;
                            break;
                        }
                       
                    }
                    if (isEqual)
                    {
                        firstWordNumber += zones[j];
                      
                    }
                    else
                    {
                        firstWordNumber -= zones[j];
                    }
                    if (firstWordNumber > 0)
                    {
                        checkPointsCounter++;
                    }
                    else
                    {
                        Console.WriteLine($"{drivers[i]} - reached {checkPointsCounter}");
                        break;
                    }
                }
                if (firstWordNumber > 0)
                {
                    Console.WriteLine($"{drivers[i]} - fuel left {firstWordNumber:f2}");
                }
               
            }     
        }
    }
}
