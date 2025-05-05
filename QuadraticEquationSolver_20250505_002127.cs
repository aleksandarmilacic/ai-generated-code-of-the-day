using System;

public class QuadraticEquationSolver
{
    public static void Main(string[] args)
    {
        Console.WriteLine(SolveQuadraticEquation(4, 7, 2));
        Console.WriteLine(SolveQuadraticEquation(4, 4, 1));
    }

    public static (double, double) SolveQuadraticEquation(double a, double b, double c)
    {
        // calculate the discriminant
        double disc = b * b - 4 * a * c;
        
        // if discriminant is less than 0, return NaN
        if (disc < 0)
        {
            return (double.NaN, double.NaN);
        }

        // calculate the roots
        double root1 = (-b + Math.Sqrt(disc)) / (2 * a);
        double root2 = (-b - Math.Sqrt(disc)) / (2 * a);

        return (root1, root2);
    }
}