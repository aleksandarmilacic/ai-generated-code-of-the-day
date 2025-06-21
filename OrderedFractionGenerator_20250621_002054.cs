using System;
using System.Collections.Generic;

public class OrderedFractionGenerator 
{
    public static void Main() 
    {
        GenerateOrderedFractions(5);
    }

    public static void GenerateOrderedFractions(int n) 
    {
        List<string> result = new List<string>();
        for (int i = 1; i <= n; i++) 
        {
            for (int j = i+1; j <= n; j++) 
            {
                result.Add(String.Format("{0}/{1}", i, j));
            }
        }
        result.Sort((a, b) => 
        {
            double aValue = Convert.ToDouble(a.Split('/')[0]) / Convert.ToDouble(a.Split('/')[1]);
            double bValue = Convert.ToDouble(b.Split('/')[0]) / Convert.ToDouble(b.Split('/')[1]);
            return aValue.CompareTo(bValue);
        });
        
        foreach (string fraction in result)
            Console.WriteLine(fraction);
    }
}