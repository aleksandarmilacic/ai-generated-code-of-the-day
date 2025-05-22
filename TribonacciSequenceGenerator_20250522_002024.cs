using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the nth number of tribonacci sequence to generate: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        long[] tribonacci = new long[n];
        
        tribonacci[0] = 0;
        tribonacci[1] = 1;
        tribonacci[2] = 1;
        
        for (int i = 3; i < n; i++)
        {
            tribonacci[i] = tribonacci[i - 1] + tribonacci[i - 2] + tribonacci[i - 3];
        }

        Console.WriteLine($"The {n}th number of the tribonacci sequence is: {tribonacci[n - 1]}");
    }
}