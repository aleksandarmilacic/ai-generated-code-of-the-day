using System;

public class NextPermutationGenerator
{
    public static void Main(string[] args)
    {
        int[] num = { 1, 2, 3 };
        GetNextPermutation(num);
        foreach (var n in num)
        {
            Console.Write(n);
        }
    }

    private static void GetNextPermutation(int[] num)
    {
        int i = num.Length - 2;
        while (i >= 0 && num[i + 1] <= num[i])
        {
            i--;
        }
        if (i >= 0)
        {
            int j = num.Length - 1;
            while (j >= 0 && num[j] <= num[i])
            {
                j--;
            }
            Swap(num, i, j);
        }
        Reverse(num, i + 1);
    }

    private static void Swap(int[] num, int i, int j)
    {
        int temp = num[i];
        num[i] = num[j];
        num[j] = temp;
    }

    private static void Reverse(int[] num, int start)
    {
        int i = start, j = num.Length - 1;
        while (i < j)
        {
            Swap(num, i, j);
            i++;
            j--;
        }
    }
}