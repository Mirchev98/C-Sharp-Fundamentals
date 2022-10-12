using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>();
            int numberOfProducts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfProducts; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);
            }
            products.Sort();

            int counter = 1;

            foreach (string product in products)
            {
                Console.WriteLine($"{counter}.{product}");
                counter++;
            }
        }
    }
}
