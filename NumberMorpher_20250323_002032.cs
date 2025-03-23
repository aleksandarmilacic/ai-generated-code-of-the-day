using System;

class NumberMorpher
{
    static int[] morphedNumbers;

    static void Main()
    {
        int[] numbers = new int[] { 10, 25, 15, 20, 35, 30, 40 };
        Morph(numbers);
        PrintMorphedNumbers();
    }

    static void Morph(int[] numbers)
    {
        int morph;
        morphedNumbers = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i == 0 || i == numbers.Length - 1)
            {
                morphedNumbers[i] = numbers[i];
            }
            else
            {
                morph = numbers[i - 1] * numbers[i + 1];
                morphedNumbers[i] = morph;
            }
        }
    }

    static void PrintMorphedNumbers()
    {
        for (int i = 0; i < morphedNumbers.Length; i++)
        {
            Console.Write(morphedNumbers[i] + " ");
        }
    }
}