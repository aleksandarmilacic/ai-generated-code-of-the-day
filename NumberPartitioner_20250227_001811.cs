using System;
using System.Collections.Generic;

class MainClass {
    static void Main(string[] args) {
        var partitions = Partition(10);
        foreach (var partition in partitions) {
            Console.WriteLine(string.Join(" + ", partition));
        }
    }

    static List<List<int>> Partition(int number) {
        return Partition(number, number, "", new List<List<int>>());
    }

    static List<List<int>> Partition(int number, int max, string prefix, List<List<int>> partitions) {
        if (number == 0) {
            var partition = new List<int>();
            foreach (var numStr in prefix.Trim().Split(' ')) {
                partition.Add(int.Parse(numStr));
            }
            partitions.Add(partition);
        }

        for (int i = Math.Min(max, number); i >= 1; i--) {
            Partition(number - i, i, prefix + " " + i, partitions);
        }

        return partitions;
    }
}