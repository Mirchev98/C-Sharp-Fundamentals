using System;
using System.Collections.Generic;

namespace _12._Need_for_Speed_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            Dictionary<string, int> carMileage = new Dictionary<string, int>();
            Dictionary<string, int> carFuel = new Dictionary<string, int>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] input = Console.ReadLine().Split("|");
                carMileage.Add(input[0], int.Parse(input[1]));
                carFuel.Add(input[0], int.Parse(input[2]));
            }

            string[] cmd = Console.ReadLine().Split(" : ");
            while (cmd[0] != "Stop")
            {
                string car = cmd[1];
                switch (cmd[0])
                {
                    case "Drive":
                        int distance = int.Parse(cmd[2]);
                        int neededFuel = int.Parse(cmd[3]);
                        if (carFuel[car] <= neededFuel)
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        else
                        {
                            Console.WriteLine($"{car} driven for {distance} kilometers. {neededFuel} liters of fuel consumed.");
                            carFuel[car] -= neededFuel;
                            if (carFuel[car] < 0)
                            {
                                carFuel[car] = 0;
                            }

                            carMileage[car] += distance;
                            if (carMileage[car] >= 100000)
                            {
                                Console.WriteLine($"Time to sell the {car}!");
                                carFuel.Remove(car);
                                carMileage.Remove(car);
                            }
                        }
                        break;
                    case "Refuel":
                        int refuel = int.Parse(cmd[2]);
                        if (carFuel[car] + refuel > 75)
                        {
                            int realRefuel = 75 - carFuel[car];
                            carFuel[car] += realRefuel;
                            Console.WriteLine($"{car} refueled with {realRefuel} liters");
                        }
                        else
                        {
                            carFuel[car] += refuel;
                            Console.WriteLine($"{car} refueled with {refuel} liters");
                        }
                        break;
                    case "Revert":
                        int kilometers = int.Parse(cmd[2]);
                        if (carMileage[car] - kilometers < 10000)
                        {
                            carMileage[car] = 10000;
                        }
                        else
                        {
                            carMileage[car] -= kilometers;
                            Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                        }
                        break;
                }
                cmd = Console.ReadLine().Split(" : ");
            }

            foreach (var km in carMileage)
            {
                foreach (var fuel in carFuel)
                {
                    if (km.Key == fuel.Key)
                    {
                        Console.WriteLine($"{km.Key} -> Mileage: {km.Value} kms, Fuel in the tank: {fuel.Value} lt.");
                    }
                }
            }
        }
    }
}
