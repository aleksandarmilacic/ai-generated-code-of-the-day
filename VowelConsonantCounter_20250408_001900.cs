using System;
using System.Linq;

class MainClass {
    static void Main() {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();
        CountVowelsAndConsonants(sentence);
    }

    static void CountVowelsAndConsonants(string sentence) {
        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
        char[] consonants = "bcdfghjklmnpqrstvwxyz".ToCharArray();
        int vowelCount = sentence.ToLower().Count(c => vowels.Contains(c));
        int consonantCount = sentence.ToLower().Count(c => consonants.Contains(c));
        Console.WriteLine("Vowels: " + vowelCount);
        Console.WriteLine("Consonants: " + consonantCount);
    }
}