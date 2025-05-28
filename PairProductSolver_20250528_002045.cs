using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        int[] input = new int[]{10, 20, 9, 40};
        int product = 400;
        Console.WriteLine(ArePairProduct(input, product));
    }

    static bool ArePairProduct(int[] arr, int product)
    {
        HashSet<int> set = new HashSet<int>();
        int n = arr.Length;

        for(int i = 0; i < n; i++)
        {
            if (arr[i] == 0)
            {
                if (product == 0)
                    return true;
                else
                    continue;
            }
            
            if(product % arr[i] == 0)
            {
                if(set.Contains(product/arr[i]))
                    return true;
                
                set.Add(arr[i]);
            }
        }

        return false;
    }
}