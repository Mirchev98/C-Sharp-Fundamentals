using System;
using System.Collections.Generic;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            Dictionary<string, string> parkingLot = new Dictionary<string, string>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] cmd = Console.ReadLine().Split();
                string currentCommand = cmd[0];
                string carOwner = cmd[1];
                

                if (currentCommand == "register")
                {
                    string carPlate = cmd[2];
                    if (parkingLot.ContainsKey(carOwner))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parkingLot[carOwner]}");
                    }
                    else
                    {
                        parkingLot.Add(carOwner, carPlate);
                        Console.WriteLine($"{carOwner} registered {carPlate} successfully");
                    }
                }
                else if (currentCommand == "unregister")
                {
                    if (!parkingLot.ContainsKey(carOwner))
                    {
                        Console.WriteLine($"ERROR: user {carOwner} not found");
                    }
                    else
                    {
                        parkingLot.Remove(carOwner);
                        Console.WriteLine($"{carOwner} unregistered successfully");
                    }
                }
            }

            foreach (var car in parkingLot)
            {
                Console.WriteLine($"{car.Key} => {car.Value}");
            }
        }
    }
}
