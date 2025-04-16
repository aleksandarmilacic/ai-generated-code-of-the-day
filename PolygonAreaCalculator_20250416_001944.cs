using System;
using System.Linq;

class Polygon
{
    public int Sides { get; }
    public double Length { get; }
    
    public Polygon(int sides, double length)
    {
        if (sides < 3) throw new ArgumentException("A polygon must have at least three sides");
        Sides = sides;
        Length = length;
    }

    public double Area()
    {
        return (Sides * Length * Length) / (4 * Math.Tan(Math.PI / Sides));
    }
}

class Program
{
    static void Main()
    {
        var polygons = new[]
        {
            new Polygon(3, 5),
            new Polygon(4, 5),
            new Polygon(5, 5),
            new Polygon(6, 5),
        };

        foreach (var polygon in polygons)
        {
            Console.WriteLine(polygon.Area());
        }
    }
}