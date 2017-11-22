using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] newCommands = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (newCommands[0] == "A" )
                {
                    phonebook[newCommands[1]] = newCommands[2];
                }
                else
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
                input = Console.ReadLine();
            }
            

   
        }
    }
}
