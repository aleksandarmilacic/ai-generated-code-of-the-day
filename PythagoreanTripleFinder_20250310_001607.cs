using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var limit = 30;
        var triples = FindPythagoreanTriples(limit);
        foreach (var triple in triples)
        {
            Console.WriteLine($"{triple.Item1}, {triple.Item2}, {triple.Item3}");
        }
    }

    static (int, int, int)[] FindPythagoreanTriples(int limit)
    {
        return (from a in Enumerable.Range(1, limit)
                from b in Enumerable.Range(a, limit)
                let c = Math.Sqrt(a * a + b * b)
                where c % 1 == 0
                select (a, b, (int)c)).ToArray();
    }
}