using System;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 7;
        
        Console.WriteLine("Before Swapping: a = " + a + ", b = " + b);
        
        a = a ^ b;
        b = a ^ b;
        a = a ^ b;
        
        Console.WriteLine("After Swapping: a = " + a + ", b = " + b);
    }
}