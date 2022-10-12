using System;
using System.Collections.Generic;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cmd = Console.ReadLine().Split(" -> ");
            Dictionary<string, List<string>> companyEmployees = new Dictionary<string, List<string>>();
            
            while (cmd[0] != "End")
            {
                string company = cmd[0];
                string employee = cmd[1];

                if (!companyEmployees.ContainsKey(company))
                {
                    companyEmployees.Add(company, new List<string>());
                }
                if (!companyEmployees[company].Contains(employee))
                {
                    companyEmployees[company].Add(employee);
                }
                cmd = Console.ReadLine().Split(" -> ");
            }

            foreach (var currCompany in companyEmployees)
            {
                Console.WriteLine(currCompany.Key);
                foreach (var worker in currCompany.Value)
                {
                    Console.WriteLine($"-- {worker}");
                }
            }
        }
    }
}
