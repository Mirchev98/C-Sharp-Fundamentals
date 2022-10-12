using System;
using System.Linq;

namespace _02._Problem_2___The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());

            int[] lift = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int totalPeople = lift.Length * 4;

            for (int i = 0; i < lift.Length; i++)
            {
                if (lift[i] == 0)
                {
                    if (people <= 4)
                    {
                        lift[i] = people;
                        people -= people;
                        
                    }
                    else
                    {
                        if (people > 4)
                        {
                            lift[i] = 4;
                            people -= 4;
                        }
                    }  
                }
                else
                {
                    int peopleToAdd = 4 - lift[i];

                    if (people >= peopleToAdd)
                    {
                        lift[i] += peopleToAdd;

                        people -= peopleToAdd;
                    }
                    else if (people < peopleToAdd)
                    {
                        lift[i] += people;
                        people = 0;
                    }


                }
            }

            if (people > 0 && lift.Sum() == totalPeople)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(String.Join(" ", lift));
            }
            else if (lift.Sum() < totalPeople && people == 0)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(String.Join(" ", lift));
            }
            else if(people == 0 && lift.Sum() == totalPeople)
            {
                Console.WriteLine(String.Join(" ", lift));
            }
        }
    }
}
