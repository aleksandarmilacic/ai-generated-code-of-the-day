using System;
using System.Collections.Generic;

public class Node
{
    public int Value;
    public Node Left;
    public Node Right;

    public Node(int value, Node left = null, Node right = null)
    {
        Value = value;
        Left = left;
        Right = right;
    }
}

public class BinaryTree
{
    public Node Root;

    public BinaryTree(int value)
    {
        Root = new Node(value);
    }

    public void Add(int value)
    {
        Node newNode = new Node(value);
        Node current = Root;
        while (current != null)
        {
            if (value < current.Value)
            {
                if (current.Left == null)
                {
                    current.Left = newNode;
                    return;
                }
                current = current.Left;
            }
            else
            {
                if (current.Right == null)
                {
                    current.Right = newNode;
                    return;
                }
                current = current.Right;
            }
        }
    }

    public List<int> PreOrder()
    {
        List<int> result = new List<int>();
        if (Root != null)
        {
            Stack<Node> stack = new Stack<Node>();
            stack.Push(Root);
            while (stack.Count > 0)
            {
                Node node = stack.Pop();
                result.Add(node.Value);

                if (node.Right != null)
                {
                    stack.Push(node.Right);
                }

                if (node.Left != null)
                {
                    stack.Push(node.Left);
                }
            }
        }
        return result;
    }
}

class Program
{
    static void Main()
    {
        BinaryTree tree = new BinaryTree(10);
        tree.Add(5);
        tree.Add(15);
        tree.Add(2);
        tree.Add(7);
        tree.Add(12);
        tree.Add(20);

        List<int> result = tree.PreOrder();
        foreach (int val in result)
        {
            Console.Write(val + " ");
        }
    }
}