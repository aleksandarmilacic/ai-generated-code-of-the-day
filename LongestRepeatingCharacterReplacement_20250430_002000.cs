using System;

public class Solution {
    public int CharacterReplacement(string s, int k) {
        int length = s.Length;
        int[] frequency = new int[26];
        int maxCount = 0, maxLength = 0;
        int start = 0;

        for (int end = 0; end < length; end++) {
            maxCount = Math.Max(maxCount, ++frequency[s[end] - 'A']);
            while (end - start + 1 - maxCount > k) {
                frequency[s[start] - 'A']--;
                start++;
            }
            maxLength = Math.Max(maxLength, end - start + 1);
        }
        return maxLength;
    }

    public static void Main() {
        Solution soln = new Solution();
        string s = "ABAB";
        int k = 2;
        Console.WriteLine(soln.CharacterReplacement(s, k));
    }
}