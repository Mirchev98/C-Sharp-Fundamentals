using System;

namespace _4._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool passLenght = LengthOfPassword(password);
            bool consistency = ValidPassword(password);
            bool digits = DigitPassword(password);

            if (!LengthOfPassword(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            
            if (!ValidPassword(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            
            if (!DigitPassword(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            
            if (LengthOfPassword(password) && ValidPassword(password) && DigitPassword(password)) 
            {
                Console.WriteLine("Password is valid");
            }
        }



        private static bool LengthOfPassword(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
      
        }
        private static bool ValidPassword(string password)
        {
            foreach (char character in password)
            {
                if (!char.IsLetterOrDigit(character))
                {
                    return false;
                }
            }
            return true;
        }
        private static bool DigitPassword(string password)
        {
            int counter = 0;

            foreach (char character in password)
            {
                if (char.IsDigit(character))
                {
                    counter++;
                }
            }
            return counter >= 2;
        }
    }
}
