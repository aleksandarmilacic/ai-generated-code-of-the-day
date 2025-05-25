using System;

class Program
{
    static void Main()
    {
        string str = Console.ReadLine();
        char[] characters = str.ToCharArray();
        int i;
        for (i = characters.Length - 1; i > 0; i--)
        {
            if (characters[i] > characters[i - 1])
            {
                break;
            }
        }
        if (i == 0)
        {
            Console.WriteLine("There is no higher permutation");
        }
        else
        {
            char x = characters[i - 1], min = characters[i];
            int index = i;

            for (int j = i + 1; j < characters.Length; j++)
            {
                if (characters[j] > x && characters[j] < min)
                {
                    min = characters[j];
                    index = j;
                }
            }

            Swap(characters, i - 1, index);
            Array.Sort(characters, i, characters.Length - i);
            Console.WriteLine(characters);
        }
    }

    static void Swap(char[] arr, int i, int j)
    {
        char temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}