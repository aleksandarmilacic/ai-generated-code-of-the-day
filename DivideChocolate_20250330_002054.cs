using System;
using System.Linq;

public class Solution {
    public int MaximizeSweetness(int[] sweetness, int K) {
        int right = sweetness.Sum() / (K + 1);
        int left = sweetness.Min();
        
        while (left < right) {
            int mid = left + (right - left + 1) / 2;
            int count = 0;
            int total = 0;
            foreach (int s in sweetness) {
                total += s;
                if (total >= mid) {
                    total = 0;
                    if (++count > K)
                        break;
                }
            }
            if (count > K)
                left = mid;
            else
                right = mid - 1;
        }
        return left;
    }
    
    public static async Task Main(string[] args) {
        Solution solution = new Solution();
        int[] sweetness = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int K = 5;
        Console.WriteLine(solution.MaximizeSweetness(sweetness, K));
    }
}