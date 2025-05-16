using System;

public class Node
{
    public int data;
    public Node next;
    public Node(int d)
    {
        data = d;
        next = null;
    }
}

public class LinkedList
{
    Node head;

    public void Push(int data)
    {
        Node temp = new Node(data);
        temp.next = head;
        head = temp;
    }

    public void Print()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.Write(temp.data + " ");
            temp = temp.next;
        }
    }

    public Node Reverse(Node head, int k)
    {
        Node current = head;
        Node next = null;
        Node prev = null;

        int count = 0;

        while (count < k && current != null)
        {
            next = current.next;
            current.next = prev;
            prev = current;
            current = next;
            count++;
        }

        if (next != null)
            head.next = Reverse(next, k);

        return prev;
    }

    public static void Main()
    {
        LinkedList list = new LinkedList();

        for (int i = 20; i > 0; i--)
            list.Push(i);

        Console.WriteLine("Given linked list");
        list.Print();
        list.head = list.Reverse(list.head, 3);

        Console.WriteLine("\nReversed Linked list");
        list.Print();
    }
}