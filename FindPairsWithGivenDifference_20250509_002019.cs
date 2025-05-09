using System;
using System.Collections.Generic;

public class FindPairsWithGivenDifference
{
  static void Main(string[] args)
  {
    int[] arr = {1, 7, 5, 9, 2, 14, 7};
    int n = 4;
    PrintPairsWithGivenDifference(arr, n);
  }

  static void PrintPairsWithGivenDifference(int[] arr, int n)
  {
    HashSet<int> hs = new();

    for(int i = 0; i < arr.Length; i++)
    {
      hs.Add(arr[i]);
    }

    for(int i = 0; i< arr.Length; i++)
    {
      if(hs.Contains(arr[i] + n))
      {
        Console.WriteLine($"({arr[i]}, {arr[i] + n})");
      }
    }
  }
}