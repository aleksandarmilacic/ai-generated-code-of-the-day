using System;

public class Knight {
    private static int N = 8;
    private static int[] dx = { 2, 1, -1, -2, -2, -1, 1, 2 };
    private static int[] dy = { 1, 2, 2, 1, -1, -2, -2, -1 };

    public static void Main() {
        SolveKnightTour();
    }

    private static bool CanMove(int x, int y, int[,] sol) {
        return (x >= 0 && x < N && y >= 0 && y < N && sol[x, y] == -1);
    }

    private static void PrintSolution(int[,] sol) {
        for (int x = 0; x < N; x++) {
            for (int y = 0; y < N; y++)
                Console.Write(sol[x, y].ToString("D2") + " ");
            Console.WriteLine();
        }
    }

    private static bool SolveKTUtil(int x, int y, int move, int[,] sol) {
        int k, nextX, nextY;
        if (move == N * N)
            return true;

        for (k = 0; k < 8; k++) {
            nextX = x + dx[k];
            nextY = y + dy[k];
            if (CanMove(nextX, nextY, sol)) {
                sol[nextX, nextY] = move;
                if (SolveKTUtil(nextX, nextY, move + 1, sol))
                    return true;
                else
                    sol[nextX, nextY] = -1;
            }
        }

        return false;
    }

    private static void SolveKnightTour() {
        int[,] sol = new int[N, N];

        for (int x = 0; x < N; x++)
            for (int y = 0; y < N; y++)
                sol[x, y] = -1;

        sol[0, 0] = 0;

        if (!SolveKTUtil(0, 0, 1, sol)) {
            Console.WriteLine("Solution does not exist");
            return;
        }

        PrintSolution(sol);
    }
}