using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace FinalAssignment
{
    public static class Solver
    {
        public static double CalculateShapes(string filePath)
        {
            var shapes = new List<Shapes3D.Shape>();
            double totalSum = 0;

            foreach (var line in File.ReadLines(filePath))
            {
                var parts = line.Split(',');
                if (parts[0] == "area" || parts[0] == "volume")
                {
                    int scale = int.Parse(parts[1]);
                    double sum = 0;

                    foreach (var shape in shapes)
                    {
                        sum += parts[0] == "area" ? shape.SurfaceArea : shape.Volume;
                    }

                    totalSum += sum * scale;
                }
                else
                {
                    AddShape(parts, shapes);
                }
            }

            return totalSum;
        }

        private static void AddShape(string[] parts, List<Shapes3D.Shape> shapes)
        {
            switch (parts[0])
            {
                case "cube":
                    shapes.Add(new Shapes3D.Cube(double.Parse(parts[1], CultureInfo.InvariantCulture)));
                    break;
                case "cuboid":
                    shapes.Add(new Shapes3D.Cuboid(
                        double.Parse(parts[1], CultureInfo.InvariantCulture),
                        double.Parse(parts[2], CultureInfo.InvariantCulture),
                        double.Parse(parts[3], CultureInfo.InvariantCulture)));
                    break;
                case "prism":
                    shapes.Add(new Shapes3D.Prism(
                        double.Parse(parts[1], CultureInfo.InvariantCulture),
                        int.Parse(parts[2]),
                        double.Parse(parts[3], CultureInfo.InvariantCulture)));
                    break;
                case "cylinder":
                    shapes.Add(new Shapes3D.Cylinder(
                        double.Parse(parts[1], CultureInfo.InvariantCulture),
                        double.Parse(parts[2], CultureInfo.InvariantCulture)));
                    break;
                case "sphere":
                    shapes.Add(new Shapes3D.Sphere(double.Parse(parts[1], CultureInfo.InvariantCulture)));
                    break;
            }
        }
    }
}
