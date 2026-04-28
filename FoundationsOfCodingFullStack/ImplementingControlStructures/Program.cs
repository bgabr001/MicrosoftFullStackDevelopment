using System;

public class Program
{
    public static void Main()
    {
        //Problem 1: Membership Fee Calculation System
        /*Console.WriteLine("Enter your age");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the type of membership (basic/Premium)");
        string membershipType = Console.ReadLine().ToLower();

        int fee = 0; 

        if (age < 18)
        {
            if (membershipType == "basic")
            {
                fee = 15;
            } else if (membershipType == "premium")
            {
                fee = 25;
            }
        } else if (age >= 18 && age < 60)
        {
            if (membershipType == "basic")
            {
                fee = 30;
            } else if (membershipType == "premium")
            {
                fee = 50;
            }
        } else
        {
            if (membershipType == "basic")
            {
                fee = 20;
            } else if (membershipType == "premium")
            {
                fee = 35;
            }
        }
        Console.WriteLine($"Your membership fee is: ${fee}");*/

        //problem 2: Bank Account Management System
        Console.WriteLine("What type of account are you opening? (savings/checking/business)");
        string accountType = Console.ReadLine().ToLower();

        double interestRate = 0;
        int monthlyFee = 0;

        switch (accountType)
        {
            case "savings":
                interestRate = 0.02;
                Console.WriteLine("Savings account opened. Interest rate: 2%");
                break;
            
            case "checking":
                monthlyFee = 10;
                Console.WriteLine("Checking account opened. Monthly fee: $10");
                break;
            
            case "business":
                interestRate = 0.01;
                monthlyFee = 20;
                Console.WriteLine("Business account opened. Interest rate: 1%, Monthly fee: $20");
                break;
            
            default:
                Console.WriteLine("Invalid account type. Please choose savings, checking, or business.");
                break;
        }
    }
}