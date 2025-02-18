using System;

class DateDurationCalculator
{
    static void Main()
    {
        DateTime date1 = new DateTime(2025, 2, 18);
        DateTime date2 = DateTime.UtcNow;

        TimeSpan diff = date2 - date1;

        Console.WriteLine($"Days: {diff.Days}, Hours: {diff.Hours}, Minutes: {diff.Minutes}, Seconds: {diff.Seconds}");
    }
}