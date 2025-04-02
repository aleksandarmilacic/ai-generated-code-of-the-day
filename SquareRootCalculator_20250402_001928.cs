using System;

public class SquareRootCalculator
{
    public static double CalculateSquareRoot(double number, double precision)
    {
        double start = 0;
        double end = number;
        double mid;  

        while ((end - start) > precision)
        {
            mid = (start + end) / 2;      
            if (mid * mid == number)
            {
                return mid;
            }
            if (mid * mid < number)
            {
                start = mid;
            }
            else
            {
                end = mid;
            }
        }
        return (start + end)/2;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Square root of 10 is: {0}", CalculateSquareRoot(10, 0.00001));  //sample execution with input 10
    }
}