using System;

class TriangleAreaCalculator
{
    static void Main(string[] args)
    {
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;

        double area = CalculateTriangleArea(sideA, sideB, sideC);
        Console.WriteLine($"Area of Triangle: {area}");
    }

    static double CalculateTriangleArea(double sideA, double sideB, double sideC)
    {
        double semiPerimeter = (sideA + sideB + sideC) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
    }
}