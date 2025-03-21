using System;
using System.Collections.Generic;

public class Solution {
    public static void Main() {
        string s = "ADOBECODEBANC";
        string t = "ABC";
        Console.WriteLine(MinWindow(s, t));
    }
    
    public static string MinWindow(string s, string t) {
        if (s.Length == 0 || t.Length == 0) {
            return "";
        }

        Dictionary<char, int> dictT = new Dictionary<char, int>();
        foreach (char c in t.ToCharArray()) {
            int count = dictT.ContainsKey(c) ? dictT[c] : 0;
            dictT[c] = count + 1;
        }

        Dictionary<char, int> dictS = new Dictionary<char, int>();
        int required = dictT.Count;
        int formed = 0;
        int l = 0, r = 0;
        int[] ans = {-1, 0, 0};

        while (r < s.Length) {
            char c = s[r];
            dictS[c] = dictS.ContainsKey(c) ? dictS[c] + 1 : 1;

            if (dictT.ContainsKey(c) && dictT[c] == dictS[c]) {
                formed++;
            }

            while (l <= r && formed == required) {
                c = s[l];
                if (ans[0] == -1 || r - l + 1 < ans[0]) {
                    ans[0] = r - l + 1;
                    ans[1] = l;
                    ans[2] = r;
                }

                dictS[c]--;
                if (dictT.ContainsKey(c) && dictS[c] < dictT[c]) {
                    formed--;
                }

                l++;
            }

            r++;   
        }

        return ans[0] == -1 ? "" : s.Substring(ans[1], ans[2] - ans[1] + 1);
    }

}