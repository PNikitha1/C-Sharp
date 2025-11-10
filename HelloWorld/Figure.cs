using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    abstract class Figure
    {
        public double Height, Width, Radius;
        public const float Pi = 3.14f;

        public abstract double Area();
    }

    class Rectangle : Figure
    {
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }

    class Circle : Figure
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Pi * Radius * Radius;
        }

    }

     class Cone : Figure
    {
        public Cone(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public override double Area()
        {
            return Pi * Radius * (Radius + Math.Sqrt(Height * Height + Radius * Radius));
        }
    }
    class MainClass
    {
        static void Main()
        {
            Rectangle r = new Rectangle(5, 10);
            Circle c = new Circle(7);
            Cone co = new Cone(7, 10);

            Console.WriteLine("Area of Rectangle: {0}" , r.Area());
            Console.WriteLine("Area of Circle: " + c.Area());
            Console.WriteLine($"Area of Cone: {co.Area()}");
        }
    }
}
