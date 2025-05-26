public class TreeAncestor
{
    int[,] parents;

    public TreeAncestor(int n, int[] parent)
    {
        parents = new int[20, n];
        for (int i = 0; i < n; i++) parents[0, i] = parent[i];
        for (int i = 1; i < 20; i++)
            for (int j = 0; j < n; j++)
                parents[i, j] = parents[i - 1, j] == -1 ? -1 : parents[i - 1, parents[i - 1, j]];
    }

    public int GetKthAncestor(int node, int k)
    {
        for (int i = 19; i >= 0 && node != -1; i--)
        {
            if ((1 << i) <= k)
            {
                node = parents[i, node];
                k -= 1 << i;
            }
        }
        return node;
    }
}

public class Program
{
    static void Main()
    {
        TreeAncestor treeAncestor = new TreeAncestor(7, new int[] { -1, 0, 0, 1, 1, 2, 2 });
        System.Console.WriteLine(treeAncestor.GetKthAncestor(3, 1));  // returns 1
        System.Console.WriteLine(treeAncestor.GetKthAncestor(5, 2));  // returns 0
        System.Console.WriteLine(treeAncestor.GetKthAncestor(6, 3));  // returns -1
    }
}