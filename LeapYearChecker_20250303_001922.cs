using System;

public static class LeapYearChecker
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(IsLeapYear(year) ? "Leap year" : "Not a leap year");
    }

    public static bool IsLeapYear(int year)
    {
        return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
    }
}