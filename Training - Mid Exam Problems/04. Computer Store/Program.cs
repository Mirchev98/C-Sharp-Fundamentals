using System;

namespace _04._Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string price = Console.ReadLine();
            double sum = 0;
            double tax = 1.2;
            double sumWithoutTax = 0;
            double taxesTotal = 0;

            while (price != "special" && price != "regular")
            {
                double currentPrice = double.Parse(price);

                if (currentPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else if (currentPrice == 0)
                {
                    Console.WriteLine("Invalid order!");
                }
                else if (currentPrice > 0)
                {
                    sum += currentPrice * tax;
                    sumWithoutTax += currentPrice;
                    taxesTotal += currentPrice * 0.2;
                }

                price = Console.ReadLine();

            }

            if (price == "special")
            {
                sum *= 0.9;
            }

            if (sum == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {sumWithoutTax:f2}$");
            Console.WriteLine($"Taxes: {taxesTotal:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {sum:f2}$");

        }
    }
}
