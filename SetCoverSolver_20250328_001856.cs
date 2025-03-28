using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var subsets = new List<HashSet<int>>
        {
            new HashSet<int> {1, 2, 3, 8},
            new HashSet<int> {2, 4, 5},
            new HashSet<int> {4, 5, 7},
            new HashSet<int> {8, 9},
            new HashSet<int> {1, 7, 9}
        };

        var universe = new HashSet<int> {1, 2, 3, 4, 5, 7, 8, 9};

        var solution = SetCoverSolver.Solve(universe, subsets);
        
        foreach (var set in solution)
        {
            Console.WriteLine(string.Join(", ", set));
        }
    }
}

public static class SetCoverSolver
{
    public static IEnumerable<HashSet<int>> Solve(HashSet<int> universe, List<HashSet<int>> subsets)
    {
        var solution = new List<HashSet<int>>();
        
        while (universe.Count > 0 && subsets.Count > 0)
        {
            var chosenSubset = ChooseBestSubset(universe, subsets);
            universe.ExceptWith(chosenSubset);
            solution.Add(chosenSubset);
        }
        
        if (universe.Count > 0) throw new Exception("No solution exists.");
        
        return solution;
    }
    
    private static HashSet<int> ChooseBestSubset(HashSet<int> universe, List<HashSet<int>> subsets)
    {
        var bestSubset = subsets[0];
        var bestIntersectCount = universe.Intersect(bestSubset).Count();
        
        foreach (var subset in subsets.Skip(1))
        {
            var intersectCount = universe.Intersect(subset).Count();
            if (intersectCount > bestIntersectCount)
            {
                bestSubset = subset;
                bestIntersectCount = intersectCount;
            }
        }
        
        subsets.Remove(bestSubset);
        return bestSubset;
    }
}