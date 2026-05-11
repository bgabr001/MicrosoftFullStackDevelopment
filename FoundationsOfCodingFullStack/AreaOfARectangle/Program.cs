//Area of a Retangle with a main and a area function
using System;
class Program
{    static void Main(string[] args)
    {
        Console.Write("Enter the length of the rectangle:");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the width of the rectangle:");
        double width = Convert.ToDouble(Console.ReadLine());
        double area = Area(length, width);
        Console.Write("The area of the rectangle is: " + area);
    }
    static double Area(double length, double width)    {
        return length * width;
    }
}   
