using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        string s1 = "ab";
        string s2 = "eidbaooo";
        
        Console.WriteLine(CheckInclusion(s1, s2));
    }
    
    public static bool CheckInclusion(string s1, string s2) 
    {
        if (s1.Length > s2.Length)
            return false;
        
        Dictionary<char, int> s1map = new Dictionary<char, int>();
        for (int i = 0; i < s1.Length; i++)
            s1map[s1[i]] = s1map.ContainsKey(s1[i]) ? s1map[s1[i]] + 1 : 1;
        
        for (int i = 0; i <= s2.Length - s1.Length; i++)
        {
            Dictionary<char, int> s2map = new Dictionary<char, int>();
            for (int j = 0; j < s1.Length; j++)
            {
                s2map[s2[i+j]] = s2map.ContainsKey(s2[i+j]) ? s2map[s2[i+j]] + 1 : 1;
            }
            if (Matches(s1map, s2map))
                return true;
        }
        return false;
    }

    public static bool Matches(Dictionary<char, int> s1map, Dictionary<char, int> s2map)
    {
        foreach (KeyValuePair<char, int> entry in s1map)
        {
            if (!s2map.ContainsKey(entry.Key) || !s2map[entry.Key].Equals(entry.Value))
                return false;
        }
        return true;
    }
}