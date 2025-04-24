using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };
        int index1 = 0;
        int index2 = 4;
        SwapElements(list, index1, index2);
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
    }

    static void SwapElements(List<int> list, int index1, int index2)
    {
        int temp = list[index1];
        list[index1] = list[index2];
        list[index2] = temp;
    }
}