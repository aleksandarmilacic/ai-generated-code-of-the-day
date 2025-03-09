using System;
using System.Collections.Generic;

public class ConnectionChecker
{
    private static readonly Dictionary<int, List<int>> AdjacencyList = new();
    
    public static void Main(string[] args)
    {
        AddConnection(1, 2);
        AddConnection(2, 3);
        AddConnection(3, 4);
        
        Console.WriteLine(AreConnected(1, 4));  // should output: True
        Console.WriteLine(AreConnected(1, 5));  // should output: False
    }

    static void AddConnection(int node1, int node2)
    {
        if (!AdjacencyList.ContainsKey(node1))
        {
            AdjacencyList[node1] = new List<int> { node2 };
        }
        else
        {
            AdjacencyList[node1].Add(node2);
        }
        
        if (!AdjacencyList.ContainsKey(node2))
        {
            AdjacencyList[node2] = new List<int> { node1 };
        }
        else
        {
            AdjacencyList[node2].Add(node1);
        }
    }

    static bool AreConnected(int node1, int node2)
    {
        HashSet<int> visited = new();
        Queue<int> queue = new();
        
        visited.Add(node1);
        queue.Enqueue(node1);

        while(queue.Count > 0)
        {
            int currentNode = queue.Dequeue();

            if (currentNode == node2)
            {
                return true;
            }

            foreach (int neighbour in AdjacencyList[currentNode])
            {
                if (!visited.Contains(neighbour))
                {
                    visited.Add(neighbour);
                    queue.Enqueue(neighbour);
                }
            }
        }

        return false;
    }
}