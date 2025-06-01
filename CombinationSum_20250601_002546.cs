using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static List<List<int>> result = new List<List<int>>();
    static void Main(string[] args)
    {
        var candidates = new[] { 2, 3, 6, 7 };
        int target = 7;
        Solve(candidates, target);
    }

    public static void Solve(int[] candidates, int target)
    {
        List<int> currentCombination = new List<int>();
        Array.Sort(candidates);
        CombinationSum(candidates, target, 0, currentCombination);
    }

    private static void CombinationSum(int[] candidates, int target, int index, List<int> currentCombination)
    {
        if (target == 0)
        {
            result.Add(new List<int>(currentCombination));
            return;
        }
        for (int i = index; i < candidates.Length; i++)
        {
            if (candidates[i] > target)
            {
                break;
            }

            currentCombination.Add(candidates[i]);
            CombinationSum(candidates, target - candidates[i], i, currentCombination);
            currentCombination.RemoveAt(currentCombination.Count - 1);
        }
    }
}