using System;

public class CircularQueue
{
    private int[] data;
    private int head;
    private int tail;
    private int size;

    public CircularQueue(int k)
    {
        data = new int[k];
        head = -1;
        tail = -1;
        size = k;
    }

    public bool EnQueue(int value)
    {
        if (IsFull())
        {
            return false;
        }
        if (IsEmpty())
        {
            head = 0;
        }
        tail = (tail + 1) % size;
        data[tail] = value;
        return true;
    }

    public bool DeQueue()
    {
        if (IsEmpty())
        {
            return false;
        }
        if (head == tail)
        {
            head = -1;
            tail = -1;
            return true;
        }
        head = (head + 1) % size;
        return true;
    }

    public int Front()
    {
        if (IsEmpty())
        {
            return -1;
        }
        return data[head];
    }

    public int Rear()
    {
        if (IsEmpty())
        {
            return -1;
        }
        return data[tail];
    }

    public bool IsEmpty()
    {
        return head == -1;
    }

    public bool IsFull()
    {
        return ((tail + 1) % size) == head;
    }

    public static async Task Main(string[] args)
    {
        CircularQueue circularQueue = new CircularQueue(5);
        Console.WriteLine(circularQueue.EnQueue(7));
        Console.WriteLine(circularQueue.DeQueue());
        Console.WriteLine(circularQueue.Front());
        Console.WriteLine(circularQueue.Rear());
        Console.WriteLine(circularQueue.IsEmpty());
        Console.WriteLine(circularQueue.IsFull());
    }
}