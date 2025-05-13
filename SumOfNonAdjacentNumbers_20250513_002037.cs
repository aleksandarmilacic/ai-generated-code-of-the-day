using System;

class Program
{
    static int FindMaxSum(int[] arr, int n)
    {
        int incl = arr[0];
        int excl = 0;
        int excl_new;
        int i;
 
        for (i = 1; i < n; i++)
        {
            excl_new = (incl > excl) ? incl : excl;
            incl = excl + arr[i];
            excl = excl_new;
        }
        return ((incl > excl) ? incl : excl);
    }
 
    public static void Main()
    {
        int[] arr = {5, 5, 10, 100, 10, 5};
        Console.Write(FindMaxSum(arr, arr.Length));
    }
}