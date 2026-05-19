//Calcualte the Volume of a Rectangualr Box 

using System;

public class Program
{
    
    public static void Main(string[] args)
    {
        Console.Write("Enter the Length of the Box: ");
        int length = int.Parse(Console.ReadLine());
        Console.Write("Enter the Width of the Box: ");
        int width = int.Parse(Console.ReadLine());
        Console.Write("Enter the Height of the Box: ");
        int height = int.Parse(Console.ReadLine());

        int volume = CalculateVolume(length, width, height);
        Console.WriteLine($"The Volume of the Box is: {volume}");

    }

    public static int CalculateVolume(int length, int width, int height)
    {
        return length * width * height;
    }
}