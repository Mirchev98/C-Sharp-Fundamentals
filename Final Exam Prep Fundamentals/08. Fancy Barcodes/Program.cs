using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _08._Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfBarcodes = int.Parse(Console.ReadLine());
            string pattern = @"@#+(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])@#+";

            for (int i = 0; i < numberOfBarcodes; i++)
            {
                string barcode = Console.ReadLine();
                Match match = Regex.Match(barcode, pattern);
                if (match.Success)
                {
                    string currBarcode = match.Groups[1].Value;
                    char[] digits = currBarcode.Where(char.IsDigit).ToArray();
                    string barcodeGroup = string.Empty;
                    if (digits.Length > 0)
                    {
                        barcodeGroup = string.Join("", digits);
                    }
                    else
                    {
                        barcodeGroup = "00";
                    }

                    Console.WriteLine($"Product group: {barcodeGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
