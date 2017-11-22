using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.AndreyAndBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var orders = new List<Customer>();
            Dictionary<string, decimal> entities = new Dictionary<string, decimal>();

            var input = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < input; i++)
            {
                var line = Console.ReadLine().Split("-".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (!entities.ContainsKey(line[0]))
                {
                    entities[line[0]] = 0;
                }
                entities[line[0]] = decimal.Parse(line[1]);
            }
            var newLine = string.Empty;
            while ((newLine = Console.ReadLine()) != "end of clients")
            {
                var splitClients = newLine.Split(",-".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

                var name = splitClients[0];
                var nameOfProduct = splitClients[1];
                var quantity = double.Parse(splitClients[2]);
                if (!entities.ContainsKey(nameOfProduct))
                {
                    continue;
                }

                Customer Customer = new Customer();
                Customer.
            }
           
        }
    }
   
    public class Customer
    {
        public string Name { get; set; }
        Dictionary<string,int> boughtProducts { get; set; }
        public double Bill { get; set; }

    }
}
