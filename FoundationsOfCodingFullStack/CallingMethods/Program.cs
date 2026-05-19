//Calling Methods

using System;

public class Program
{
      public static bool IsOldEnoughToVote(int age)
    {
        if (age >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

       static void Main(string[] args)
    {
        Console.Write("What is your age? ");
        int userAge = Convert.ToInt32(Console.ReadLine());

        bool canVote = IsOldEnoughToVote(userAge);

        if (canVote)
        {
            Console.WriteLine("You are old enough to vote!");
        }
        else
        {
            Console.WriteLine("You are not old enough to vote.");
        }
    }
         
       
}

