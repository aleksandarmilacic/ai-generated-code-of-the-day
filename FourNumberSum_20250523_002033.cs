using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 0, -1, 0, -2, 2 };
        int target = 0;
        var results = FourNumberSum(arr, target);
        foreach(var list in results)
        {
            Console.WriteLine(string.Join(", ", list));
        }
    }

    static List<List<int>> FourNumberSum(int[] array, int targetSum)
    {
        var allPairSums = new Dictionary<int, List<List<int>>>();
        var quadruplets = new List<List<int>>();
        for (int i = 1; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                var currentSum = array[i] + array[j];
                var difference = targetSum - currentSum;
                if (allPairSums.ContainsKey(difference))
                {
                    foreach (var pair in allPairSums[difference])
                    {
                        var newQuadruplet = new List<int>();
                        newQuadruplet.Add(pair[0]);
                        newQuadruplet.Add(pair[1]);
                        newQuadruplet.Add(array[i]);
                        newQuadruplet.Add(array[j]);
                        quadruplets.Add(newQuadruplet);
                    }
                }
            }

            for (int k = 0; k < i; k++)
            {
                var currentSum = array[i] + array[k];
                if (!allPairSums.ContainsKey(currentSum))
                {
                    allPairSums.Add(currentSum, new List<List<int>> { new List<int> { array[k], array[i] } });
                }
                else
                {
                    allPairSums[currentSum].Add(new List<int> { array[k], array[i] });
                }
            }
        }
        return quadruplets;
    }
}