using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> handsOfCards = new Dictionary<string, HashSet<string>>();
            string input = Console.ReadLine();

            while (input != "JOKER")
            {
                string[] inputSplit = input.Split(':');
                string name = inputSplit[0];
                string[] cards = inputSplit[1].Trim().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (!handsOfCards.ContainsKey(name))
                {
                    handsOfCards[name] = new HashSet<string>();
                }

                for (int i = 0; i < cards.Length; i++)
                {
                    handsOfCards[name].Add(cards[i]);
                }

                input = Console.ReadLine();
            }

            foreach (var item in handsOfCards)
            {
                int allSum = 0;
                foreach (var cards in item.Value)
                {
                    string power = cards.Substring(0, cards.Length - 1);
                    string type = cards.Substring(cards.Length - 1);
                    
                    int sum = Power(power) * Type(type);
                    allSum += sum;
                }
                Console.WriteLine($"{item.Key}: {allSum}");
            }

        }

        public static int Power(string power)
        {
            Dictionary<string, int> typeResult = new Dictionary<string, int>();
            typeResult["2"] = 2;
            typeResult["3"] = 3;
            typeResult["4"] = 4;
            typeResult["5"] = 5;
            typeResult["6"] = 6;
            typeResult["7"] = 7;
            typeResult["8"] = 8;
            typeResult["9"] = 9;
            typeResult["10"] = 10;
            typeResult["J"] = 11;
            typeResult["Q"] = 12;
            typeResult["K"] = 13;
            typeResult["A"] = 14;

            return typeResult[power];
        }

        public static int Type(string type)
        {
            Dictionary<string, int> typeResult = new Dictionary<string, int>();
            typeResult["S"] = 4;
            typeResult["H"] = 3;
            typeResult["D"] = 2;
            typeResult["C"] = 1;

            return typeResult[type];
        }


    }
}
