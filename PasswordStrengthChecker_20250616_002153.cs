using System;
using System.Linq;

namespace PasswordStrengthChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();

            if (IsPasswordStrong(password))
            {
                Console.WriteLine("Password strength: STRONG");
            }
            else
            {
                Console.WriteLine("Password strength: WEAK");
            }
        }

        static bool IsPasswordStrong(string password)
        {
            bool hasUpper = password.Any(char.IsUpper);
            bool hasLower = password.Any(char.IsLower);
            bool hasDigits = password.Any(char.IsDigit);
            bool hasNonAlphanumeric = password.Any(char.IsSymbol);

            return hasUpper && hasLower && hasDigits && hasNonAlphanumeric && password.Length >= 8;
        }
    }
}