using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {

            var dict = new Dictionary<string, string>();

            while (true)
            {
                var name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }
                var email = Console.ReadLine();

                dict[name] = email;

            }

            foreach (var item in dict)
            {
                if (dict[item.Key].EndsWith("bg"))
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }


        }
    }
}
