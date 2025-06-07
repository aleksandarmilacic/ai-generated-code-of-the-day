using System;
using System.Linq;

class SequenceReverser
{
    static void Main()
    {
        int[] sequence = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        sequence = ReverseSequence(sequence);

        foreach (var item in sequence)
            Console.WriteLine(item);
    }

    static int[] ReverseSequence(int[] sequence)
    {
        return sequence.Reverse().ToArray();
    }
}