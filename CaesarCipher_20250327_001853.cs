using System;

public class Program
{
    public static void Main()
    {
        string input = "HELLO WORLD";
        int shift = 3;
        string encrypted = CaesarCipher.Encrypt(input, shift);
        Console.WriteLine(encrypted);
        string decrypted = CaesarCipher.Decrypt(encrypted, shift);
        Console.WriteLine(decrypted);
    }
}

public static class CaesarCipher
{
    public static string Encrypt(string input, int shift)
    {
        char[] buffer = input.ToCharArray();
        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];
            letter = (char)(letter + shift);
            if (letter > 'Z')
            {
                letter = (char)(letter - 26);
            }
            else if (letter < 'A')
            {
                letter = (char)(letter + 26);
            }
            buffer[i] = letter;
        }
        return new string(buffer);
    }

    public static string Decrypt(string input, int shift)
    {
        return Encrypt(input, 26 - shift);
    }
}