using System;

public class Program
{
    public static void Main(string[] args)
    {

Console.WriteLine("get the total Score");
int [] scores = {85, 90, 78, 92, 88};
 int totalScore = 0;

for (int i =0; i < scores.Length; i++)
{
    totalScore += scores[i];
    Console.WriteLine($"Score {i + 1}: {scores[i]}");
}
Console.WriteLine($"Total Score: {totalScore}");
//line break

Console.WriteLine("\n");

//////////////////////////////////////////////////
/*Console.WriteLine("Calcualte facotrial of a number");

int number = 0;
Console.Write("Enter a number to calculate its factorial: ");
number = Convert.ToInt32(Console.ReadLine());
int factorial = 1;
for (int i = 1; i <= number; i++)
{
    factorial *= i;
}  
Console.WriteLine($"Factorial of {number} is: {factorial}");*/

//Combine Loops and If-else to determine Pass or Fail

/*int [] studentScores = {45, 60, 72, 38, 55};
for (int i = 0; i < studentScores.Length; i++)
{
    if (studentScores[i] >= 50)
    {
        Console.WriteLine($"Student {i + 1} passed with a score of {studentScores[i]}");
    }
    else
    {
        Console.WriteLine($"Student {i + 1} failed with a score of {studentScores[i]}");
    }
}*/

//Combining Loops and Switch Statemtn for Task Scheduling
string [] weekDays = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};

/*for (int i = 0; i < weekDays.Length; i++)
{
    Console.WriteLine($"Tasks for {weekDays[i]}:");
    switch (weekDays[i])
    {
        case "Monday":
            Console.WriteLine("- Team Meeting");
            break;
        case "Tuesday":
            Console.WriteLine("- Code Review");
            break;
        case "Wednesday":
            Console.WriteLine("- Development");
           
            break;
        case "Thursday":
            Console.WriteLine("- Testing");
         
            break;
        case "Friday":
            Console.WriteLine("- Deployment");
            
            break;
        default:
            Console.WriteLine("No tasks scheduled.");
            break;
    }
    Console.WriteLine(); // Line break for better readability
}*/

    }
}


