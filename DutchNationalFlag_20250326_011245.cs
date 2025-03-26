using System;

class Program
{
    static void Main()
    {
        int[] arr = { 0, 2, 1, 2, 0, 1, 2, 0, 1, 2, 0, 1, 2 };
        DutchNationalFlagAlgorithm(arr);
        Console.WriteLine(string.Join(", ", arr));
    }

    static void DutchNationalFlagAlgorithm(int[] arr)
    {
        int low = 0;
        int mid = 0;
        int high = arr.Length - 1;

        while (mid <= high)
        {
            switch (arr[mid])
            {
                case 0:
                    Swap(arr, low, mid);
                    low++;
                    mid++;
                    break;
                case 1:
                    mid++;
                    break;
                case 2:
                    Swap(arr, mid, high);
                    high--;
                    break;
            }
        }
    }

    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}