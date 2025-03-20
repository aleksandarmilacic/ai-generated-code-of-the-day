using System;

namespace SortingLinkedList
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }

    public class LinkedList
    {
        public Node Head { get; set; }

        public void Add(int value)
        {
            Node newNode = new Node { Value = value };
            if (Head == null)
            {
                Head = newNode;
                return;
            }

            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }

        public void Sort()
        {
            Node current = Head, index = null;
            int temp;

            if (Head == null)
            {
                return;
            }
            else
            {
                while (current != null)
                {
                    index = current.Next;

                    while (index != null)
                    {
                        if (current.Value > index.Value)
                        {
                            temp = current.Value;
                            current.Value = index.Value;
                            index.Value = temp;
                        }
                        index = index.Next;
                    }
                    current = current.Next;
                }
            }
        }

        public void Print()
        {
            Node current = Head;
            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(9);
            list.Add(7);
            list.Add(2);
            list.Add(6);
            list.Add(1);
            list.Sort();
            list.Print();
        }
    }
}