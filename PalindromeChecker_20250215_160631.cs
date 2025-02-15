using System;

namespace CodeOfTheDay
{
    class PalindromeChecker_20250215_160631
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to check:");
            string input = Console.ReadLine();

            string reversed = ReverseString(input);
            bool isPalindrome = input == reversed;

            Console.WriteLine(isPalindrome ? "Palindrome" : "Not a palindrome");
        }

        private static string ReverseString(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}