using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "print")
            {
                string[] longCommands = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                switch (longCommands[0])
                {
                    case "add":
                        int index = int.Parse(longCommands[1]);
                        int element = int.Parse(longCommands[2]);
                        numbers.Insert(index, element);
                        break;
                    case "addMany":
                        index = int.Parse(longCommands[1]);
                        numbers.InsertRange(index, longCommands.Skip(2).Select(int.Parse).ToList());
                        break;
                    case "contains":
                        element = int.Parse(longCommands[1]);
                        Console.WriteLine(numbers.IndexOf(element));
                        break;
                    case "remove":
                        index = int.Parse(longCommands[1]);
                        numbers.RemoveAt(index);
                        break;
                    case "shift":
                        int pos = int.Parse(longCommands[1]);
                        for (int i = 0; i < pos; i++)
                        {
                            int temp = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(temp);
                        }

                        break;
                    case "sumPairs":
                        List<int> tempList = new List<int>();

                        if (numbers.Count % 2 == 0)
                        {
                            for (int i = 0; i < numbers.Count; i += 2)
                            {
                                int firstNumber = numbers[i];
                                int secondNumber = numbers[i + 1];
                                tempList.Add(firstNumber + secondNumber);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < numbers.Count - 1; i += 2)
                            {
                                int firstNumber = numbers[i];
                                int secondNumber = numbers[i + 1];
                                tempList.Add(firstNumber + secondNumber);
                            }

                            tempList.Add(numbers[numbers.Count - 1]);
                        }
                        numbers.Clear();
                        numbers.AddRange(tempList);
                        break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}
