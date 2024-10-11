using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the length of the rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the width of the rectangle: ");
        double width = Convert.ToDouble(Console.ReadLine());

        double area = length * width;

        Console.WriteLine("The area of the rectangle with length " + length + " and width " + width + " is: " + area);
    }
}