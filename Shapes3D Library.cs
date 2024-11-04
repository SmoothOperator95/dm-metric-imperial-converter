using System;

namespace Shapes3D
{
    public abstract class Shape
    {
        public abstract double SurfaceArea { get; }
        public abstract double Volume { get; }
    }

    public class Cuboid : Shape
    {
        private double width;
        private double height;
        private double depth;

        public Cuboid(double width, double height, double depth)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
        }

        public override double SurfaceArea => 2 * (width * height + width * depth + height * depth);
        public override double Volume => width * height * depth;
    }

    public class Cube : Cuboid
    {
        public Cube(double sideLength) : base(sideLength, sideLength, sideLength) { }
    }

    public class Cylinder : Shape
    {
        private double radius;
        private double height;

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public override double SurfaceArea => 2 * Math.PI * radius * (radius + height);
        public override double Volume => Math.PI * radius * radius * height;
    }

    public class Sphere : Shape
    {
        private double radius;

        public Sphere(double radius)
        {
            this.radius = radius;
        }

        public override double SurfaceArea => 4 * Math.PI * radius * radius;
        public override double Volume => (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
    }

    public class Prism : Shape
    {
        private double sideLength;
        private int faces;
        private double height;

        public Prism(double sideLength, int faces, double height)
        {
            this.sideLength = sideLength;
            this.faces = faces;
            this.height = height;
        }

        public override double SurfaceArea => (faces * sideLength * height) + (faces * sideLength * sideLength / (4 * Math.Tan(Math.PI / faces)));
        public override double Volume => (1.0 / 2.0) * faces * sideLength * height;
    }
}
