using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> itegers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string commands = Console.ReadLine();

            while (commands != "Odd" && commands != "Even")
            {

                List<string> newCommand = commands.Split(' ').ToList();

                string cmd = newCommand[0];
                switch (cmd)
                {
                    case "Delete":
                        itegers.RemoveAll(e => e == int.Parse(newCommand[1]));
                        break;
                    case "Insert":
                        itegers.Insert(int.Parse(newCommand[2]), int.Parse(newCommand[1]));
                        break;
                }
                

                commands = Console.ReadLine();
            }

           // Console.WriteLine(string.Join(" ", itegers.Where(e => e % 2 != 0)));
           // Console.WriteLine(string.Join(" ", itegers.Where(e => e % 2 != 1)));

            if (commands == "Odd")
            {
                for (int i = 0; i < itegers.Count ; i++)
                {
                    if (itegers[i] % 2 != 0)
                    {
                        Console.Write(itegers[i] + " ");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < itegers.Count; i++)
                {
                    if (itegers[i] % 2 == 0)
                    {
                        Console.Write(itegers[i] + " ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
