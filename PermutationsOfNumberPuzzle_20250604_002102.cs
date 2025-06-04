using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        int[] nums = {1, 2, 3};
        var result = Permute(nums);
        foreach (var res in result)
        {
            foreach (var num in res)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }

    private static IList<IList<int>> Permute(int[] nums)
    {
        IList<IList<int>> list = new List<IList<int>>();
        Backtrack(list, new List<int>(), nums);
        return list;
    }

    private static void Backtrack(IList<IList<int>> list, List<int> tempList, int [] nums)
    {
        if(tempList.Count == nums.Length)
        {
            list.Add(new List<int>(tempList));
        }
        else
        {
            for(int i = 0; i < nums.Length; i++)
            { 
                if(tempList.Contains(nums[i])) continue;
                tempList.Add(nums[i]);
                Backtrack(list, tempList, nums);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }
    }
}