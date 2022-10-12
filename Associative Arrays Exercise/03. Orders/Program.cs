using System;
using System.Collections.Generic;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> nameAndPrice = new Dictionary<string, double>();
            Dictionary<string, int> nameAndQuantity = new Dictionary<string, int>();

            string[] cmd = Console.ReadLine().Split();

            while (cmd[0] != "buy")
            {
                string name = cmd[0];
                double price = double.Parse(cmd[1]);
                int quantity = int.Parse(cmd[2]);

                if (!nameAndPrice.ContainsKey(name))
                {
                    nameAndPrice[name] = 0;
                    nameAndQuantity[name] = 0;
                }
                nameAndPrice[name] = price;
                nameAndQuantity[name] += quantity;

                cmd = Console.ReadLine().Split();
            }

            foreach (var order in nameAndPrice)
            {
                foreach (var nextOrder in nameAndQuantity)
                {
                    if (order.Key == nextOrder.Key)
                    {
                        Console.WriteLine($"{order.Key} -> {order.Value * nextOrder.Value:f2}");
                    }
                }
            }
        }
    }
}
