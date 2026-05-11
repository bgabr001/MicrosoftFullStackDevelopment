using System;

public class Program
{
    public static void Main(string[] args)
    {
       //Integrating If-Else with Loops
       //Create a program that repeatedly ask the user to enter a number between 1 and 10 
       // and ensures the numbner is even 
           int input;
		do {
			Console.WriteLine("Enter an even number between 1 and 10:");
			input = int.Parse(Console.ReadLine());
			if (input >= 1 && input <= 10 && input % 2 == 0) {
				Console.WriteLine("Valid input: " + input);
				break;
			} else {
				Console.WriteLine("Invalid input. Please try again.");
			}

		} while (true);
    }
}

