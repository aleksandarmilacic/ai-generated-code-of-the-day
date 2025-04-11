using System;

public class Solution {
    public int MinCut(string s) {
        int n = s.Length;
        bool[,] dp = new bool[n,n];
        int[] cut = new int[n];
        for (int j = 0; j < n; j++) {
            cut[j] = j;
            for (int i = 0; i <= j; i++) {
                if (s[i] == s[j] && (j - i <= 1 || dp[i+1,j-1])) {
                    dp[i,j] = true;
                    if (i > 0) cut[j] = Math.Min(cut[j], cut[i-1] + 1);
                    else cut[j] = 0;
                }
            }
        }
        return cut[n-1];
    }
    
    static void Main(string[] args) {
        Solution sol = new Solution();
        Console.WriteLine(sol.MinCut("aaabaa"));
    }
}