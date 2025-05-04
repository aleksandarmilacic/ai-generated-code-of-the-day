using System;

public class Node
{
    public int Value;
    public Node Left;
    public Node Right;

    public Node(int value)
    {
        Value = value;
    }
}

public class BinaryTree
{
    public Node Root;

    public bool IsBalanced()
    {
        return CheckHeight(Root) != int.MinValue;
    }

    int CheckHeight(Node root)
    {
        if (root == null) return -1;

        int leftHeight = CheckHeight(root.Left);
        if (leftHeight == int.MinValue) return int.MinValue;

        int rightHeight = CheckHeight(root.Right);
        if (rightHeight == int.MinValue) return int.MinValue;

        int heightDiff = leftHeight - rightHeight;
        if (Math.Abs(heightDiff) > 1)
        {
            return int.MinValue;
        }
        else
        {
            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }
}

public class Program
{
    static void Main()
    {
        var tree = new BinaryTree();
        tree.Root = new Node(1);
        tree.Root.Left = new Node(2);
        tree.Root.Right = new Node(3);
        tree.Root.Left.Left = new Node(4);
        tree.Root.Left.Right = new Node(5);
        tree.Root.Right.Left = new Node(6);
        tree.Root.Right.Right = new Node(7);
        Console.WriteLine(tree.IsBalanced());
    }
}