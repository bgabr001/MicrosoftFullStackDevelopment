using System;

class Program
{
  static double CalculateArea(double radius)
  {
    return Math.PI * radius * radius;
  }
  static void Main(string[] args)
    {
        Console.Write("Enter the radius of the circle:");
        double radius = Convert.ToDouble(Console.ReadLine());
        double area = CalculateArea(radius);
        Console.WriteLine($"The area of the circle with radius {radius} is: {area}");
    }
}