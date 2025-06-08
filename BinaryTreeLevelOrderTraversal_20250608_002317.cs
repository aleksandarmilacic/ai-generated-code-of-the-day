using System;
using System.Collections.Generic;

public class Node
{
    public int Value;
    public Node Left;
    public Node Right;

    public Node(int value, Node left = null, Node right = null)
    {
        this.Value = value;
        this.Left = left;
        this.Right = right;
    }
}

public class BTree
{
    public Node Root;

    public BTree(int rootValue)
    {
        this.Root = new Node(rootValue);
    }

    public void LevelOrderTraversal()
    {
        if (this.Root == null) return;

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(this.Root);

        while (queue.Count > 0)
        {
            Node node = queue.Dequeue();

            Console.Write(node.Value + " ");

            if (node.Left != null)
            {
                queue.Enqueue(node.Left);
            }

            if (node.Right != null)
            {
                queue.Enqueue(node.Right);
            }
        }
    }
}

class Program
{
    static void Main()
    {
        BTree bTree = new BTree(1);
        bTree.Root.Left = new Node(2);
        bTree.Root.Right = new Node(3);
        bTree.Root.Left.Left = new Node(4);
        bTree.Root.Left.Right = new Node(5);

        bTree.LevelOrderTraversal();
    }
}