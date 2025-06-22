using System;
using System.Collections.Generic;

public class UniqueSubsets
{
    public List<List<int>> GenerateUniqueSubsets(int[] nums)
    {
        Array.Sort(nums);
        List<List<int>> subsets = new List<List<int>>();
        Generate(nums, new List<int>(), 0, subsets);
        return subsets;
    }

    private void Generate(int[] nums, List<int> current, int start, List<List<int>> subsets)
    {
        subsets.Add(new List<int>(current));
        for (int i = start; i < nums.Length; i++)
        {
            if (i != start && nums[i] == nums[i - 1]) continue;
            current.Add(nums[i]);
            Generate(nums, current, i + 1, subsets);
            current.RemoveAt(current.Count - 1);
        }
    }

    private static void Main(string[] args)
    {
        UniqueSubsets generator = new UniqueSubsets();
        int[] nums = new int[] { 1, 2, 2 };

        List<List<int>> subsets = generator.GenerateUniqueSubsets(nums);

        foreach (var subset in subsets)
        {
            Console.WriteLine(string.Join(",", subset));
        }
    }
}