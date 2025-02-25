using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Tuple<int, int>> intervals = new List<Tuple<int, int>>()
        {
            Tuple.Create(1, 4),
            Tuple.Create(2, 5),
            Tuple.Create(7, 9),
            Tuple.Create(8, 10),
            Tuple.Create(11, 13)
        };

        List<Tuple<int, int>> result = RemoveIntervalOverlaps(intervals);

        foreach (var interval in result)
        {
            Console.WriteLine($"[{interval.Item1}, {interval.Item2}]");
        }
    }

    static List<Tuple<int, int>> RemoveIntervalOverlaps(List<Tuple<int, int>> intervals)
    {
        var sortedIntervals = intervals.OrderBy(x => x.Item1).ToList();
        var result = new List<Tuple<int, int>>();

        int start = sortedIntervals[0].Item1;
        int end = sortedIntervals[0].Item2;

        for (int i = 1; i < sortedIntervals.Count; i++)
        {
            if (sortedIntervals[i].Item1 <= end)
            {
                end = Math.Max(sortedIntervals[i].Item2, end);
            }
            else
            {
                result.Add(Tuple.Create(start, end));
                start = sortedIntervals[i].Item1;
                end = sortedIntervals[i].Item2;
            }
        }

        result.Add(Tuple.Create(start, end));

        return result;
    }
}