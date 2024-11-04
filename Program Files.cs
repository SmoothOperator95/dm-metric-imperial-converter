using System;
using System.IO;

namespace ShapeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: ShapeCalculator <filename>");
                return;
            }

            string filePath = args[0];

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            double totalSum = FinalAssignment.Solver.CalculateShapes(filePath);
            Console.WriteLine($"The sum of measurements is {totalSum:N2}.");
        }
    }
}
