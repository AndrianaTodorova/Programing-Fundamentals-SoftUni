using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        private static Dictionary<char, int> winningSymbols = new Dictionary<char, int>
        {
            ['@'] = 0,
            ['#'] = 0,
            ['$'] = 0,
            ['^'] = 0
        };

        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine()
                                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder result = new StringBuilder();
            foreach (string ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    result.AppendLine("invalid ticket");
                }
                else
                {
                    string leftPart = CreateString(ticket.Take(10));
                    string rightPart = CreateString(ticket.Skip(10));

                    string winningLeftString = GetWinningString(leftPart);
                    string winningRightString = GetWinningString(rightPart);

                    if (winningLeftString == string.Empty)
                    {
                        result.AppendLine($"ticket \"{ticket}\" - no match");
                    }
                    else
                    {
                        if (winningLeftString.Contains(winningRightString) ||
                            winningRightString.Contains(winningLeftString))
                        {
                            if (winningLeftString.Length == 10)
                            {
                                result.AppendLine($"ticket \"{ticket}\" - {winningLeftString.Length}{winningLeftString[0]} Jackpot!");
                            }
                            else
                            {
                                result.AppendLine($"ticket \"{ticket}\" - {winningLeftString.Length}{winningLeftString[0]}");
                            }
                        }
                        else
                        {
                            result.AppendLine($"ticket \"{ticket}\" - no match");
                        }
                    }
                }
            }

            Console.Write(result);
        }

        private static string GetWinningString(string leftPart)
        {
            foreach (char symbol in leftPart)
            {
                if (winningSymbols.ContainsKey(symbol))
                {
                    winningSymbols[symbol]++;
                }
            }

            KeyValuePair<char, int> test = winningSymbols
                                           .FirstOrDefault(kvp => kvp.Value >= 6);

            if (test.Equals(default(KeyValuePair<char, int>)))
            {
                return string.Empty;
            }

            string toReturn = new string(test.Key, test.Value);

            winningSymbols = new Dictionary<char, int>
            {
                ['@'] = 0,
                ['#'] = 0,
                ['$'] = 0,
                ['^'] = 0
            };

            return toReturn;
        }

        private static string CreateString(IEnumerable<char> chars)
        {
            return new string(chars.ToArray());
        }
    }
}
