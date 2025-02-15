using System;

public class UniqueAlgorithm_20250215_153257
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter an integer:");
        int n = Convert.ToInt32(Console.ReadLine());
        
        int[] arr = GenerateArray(n);
        
        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
    }
    
    public static int[] GenerateArray(int n)
    {
        int[] arr = new int[n];
        
        for (int i=0; i<n; i++)
        {
            arr[i] = FindMagicNumber(i+1);
        }
        
        return arr;
    }
    
    public static int FindMagicNumber(int n)
    {
        int magicNumber = 0;
        int temp = n;
        int digit;
        
        while (temp > 0)
        {
            digit = temp % 10;
            magicNumber += digit * digit * digit;
            temp /= 10;
        }
        
        return magicNumber * n;
    }
}