using System;

class Program 
{
    static void Main()
    {
        int[] puzzle = {5, 1, 8, 4, 3, 6, 2, 7};
        PuzzleSolver solver = new PuzzleSolver();
        solver.SolvePuzzle(puzzle);
    }
}

public class PuzzleSolver
{
    public void SolvePuzzle(int[] puzzle)
    {
        Array.Sort(puzzle);
        int targetSum = puzzle[0] + puzzle[1];

        bool isSolutionFound = false;
        for(int i = 2; i < puzzle.Length; i++)
        {
            isSolutionFound = SearchPair(puzzle, i, targetSum);
            if(isSolutionFound)
            {
                break;
            }
        }

        if(!isSolutionFound)
        {
            Console.WriteLine("No solution found for the given puzzle.");
        }
    }

    private bool SearchPair(int[] arr, int start, int targetSum)
    {
        int end = arr.Length - 1;
        while(start < end)
        {
            int sum = arr[start] + arr[end];
            if(sum == targetSum)
            {
                Console.WriteLine($"Solution Found: {arr[start]}, {arr[end]}");
                return true;
            }

            if(sum < targetSum)
            {
                start++;
            }
            else
            {
                end--;
            }
        }

        return false;
    }
}