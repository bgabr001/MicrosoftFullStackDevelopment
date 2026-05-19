using System;

public class Program
{

    public static void Main()
    {
        static int CalculateSum (int a, int b)
        {
           return a + b; 
        }    

        int sum = CalculateSum(5, 10);
        Console.WriteLine($"The sum of 5 and 10 is: {sum}");
    }


}
