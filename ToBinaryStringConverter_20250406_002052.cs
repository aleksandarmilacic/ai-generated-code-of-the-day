using System;

class Program {
    static void Main() {
        Console.WriteLine(ToBinaryString(47));
    }

    static string ToBinaryString(int n) {
        return Convert.ToString(n, 2);
    }
}