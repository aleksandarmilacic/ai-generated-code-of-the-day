using System;

class Program
{
    static void Main()
    {
        Tuple<int, int> start = new Tuple<int, int>(1, 1);
        Tuple<int, int> end = new Tuple<int, int>(2, 3);

        Console.WriteLine(CanKnightMove(start, end));
    }

    static bool CanKnightMove(Tuple<int, int> start, Tuple<int, int> end)
    {
        int dx = Math.Abs(start.Item1 - end.Item1);
        int dy = Math.Abs(start.Item2 - end.Item2);

        return (dx == 2 && dy == 1) || (dx == 1 && dy == 2);
    }
}