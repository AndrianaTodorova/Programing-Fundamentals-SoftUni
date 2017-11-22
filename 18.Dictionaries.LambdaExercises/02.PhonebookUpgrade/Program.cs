using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new SortedDictionary<string, string>();
            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] newCommands = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (newCommands[0] == "A")
                {
                   
                    phonebook[newCommands[1]] = newCommands[2];
                } 
                  else if(newCommands[0] == "S")
                {
                    if (!phonebook.ContainsKey(newCommands[1]))
                    {
                        Console.WriteLine($"Contact {newCommands[1]} does not exist.");
                    }
                    else
                    {
                        Console.WriteLine($"{newCommands[1]} -> {phonebook[newCommands[1]]}");
                    }
                }
                else
                {
                    foreach (var pair in phonebook)
                    {
                        Console.WriteLine(pair.Key + " -> " + pair.Value);
                    }
                }
                input = Console.ReadLine();
            }

        }
    }
}
