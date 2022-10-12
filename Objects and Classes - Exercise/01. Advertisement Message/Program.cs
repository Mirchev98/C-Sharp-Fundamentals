using System;

namespace _01._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = 
            { 
                "Excellent product.", "Such a great product.", "I always use that product.", 
                "Best product of its category.", "Exceptional product.", 
                "I can't live without this product." 
            };

            string[] events =
            {
                "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!"
            };

            string[] author = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] city = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int numberOfMessages = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfMessages; i++)
            {
                Random random = new Random();

                int randomIndex = random.Next(0, phrases.Length - 1);
                Console.Write(phrases[randomIndex] + " ");

                randomIndex = random.Next(0, events.Length - 1);
                Console.Write(events[randomIndex] + " ");

                randomIndex = random.Next(0, author.Length - 1);
                Console.Write(author[randomIndex] + " - ");

                randomIndex = random.Next(0, city.Length - 1);
                Console.Write(city[randomIndex]);
                Console.WriteLine();
            }
        }
    }
}
