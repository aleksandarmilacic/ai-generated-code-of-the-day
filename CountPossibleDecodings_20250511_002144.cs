using System;

class CountPossibleDecodings
{
    static int CountWays(string digits, int length)  
    {  
        int[] count = new int[length + 1];  
        count[0] = 1;  
        count[1] = 1;  

        for (int i = 2; i <= length; i++)  
        {  
            count[i] = 0;  

            if (digits[i - 1] > '0')  
            {  
                count[i] = count[i - 1];  
            } 

            if (digits[i - 2] == '1' || (digits[i - 2] == '2' && digits[i - 1] <= '6'))  
            {  
               count[i] += count[i - 2];  
            }  
        }  
        return count[length];  
    }  
    
    static void Main(string[] args)
    {
        Console.WriteLine(CountWays("11111", 5));  
        Console.WriteLine(CountWays("24726", 5));  
    }  
}