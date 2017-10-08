using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ForeignLanguages
{
   
namespace _05.ForeignLaunguages
    {
        class Program
        {
            static void Main(string[] args)
            {
                string country = Console.ReadLine();
                string launguage = "";

                if (country == "USA" || country == "England")
                {
                    launguage = "English";
                }
                else if (country == "Spain" || country == "Argentina" || country == "Mexico")
                {
                    launguage = "Spanish";
                }
                else
                {
                    launguage = "unknown";
                }
                Console.WriteLine(launguage);

            }
        }
    }

}
    
