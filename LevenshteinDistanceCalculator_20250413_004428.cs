using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(LevenshteinDistance("kitten", "sitting"));
    }

    static int LevenshteinDistance(string str1, string str2)
    {
        int[,] dist = new int[str1.Length + 1, str2.Length + 1];
        for (int i = 0; i <= str1.Length; i++)
            dist[i, 0] = i;
        for (int j = 0; j <= str2.Length; j++)
            dist[0, j] = j;
        
        for (int i = 1; i <= str1.Length; i++)
        {
            for (int j = 1; j <= str2.Length; j++)
            {
                int cost = (str1[i - 1] == str2[j - 1]) ? 0 : 1;
                dist[i, j] = Math.Min(Math.Min(dist[i - 1, j] + 1, dist[i, j - 1] + 1), dist[i - 1, j - 1] + cost);
            }
        }
        return dist[str1.Length, str2.Length];
    }
}