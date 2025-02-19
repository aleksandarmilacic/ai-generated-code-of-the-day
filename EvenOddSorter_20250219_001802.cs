using System;

class Program
{
    static void Main()
    {
        int[] arr = { 4, 1, 3, 2, 8, 5, 7, 6 };
        SortArrayByParity(arr);
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }

    static void SortArrayByParity(int[] A)
    {
        int i = 0, j = A.Length - 1;
        while (i < j)
        {
            if (A[i] % 2 > A[j] % 2)
            {
                int tmp = A[i];
                A[i] = A[j];
                A[j] = tmp;
            }

            if (A[i] % 2 == 0) i++;
            if (A[j] % 2 == 1) j--;
        }
    }
}