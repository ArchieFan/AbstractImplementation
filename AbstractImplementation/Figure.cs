using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractImplementation
{
    public abstract class Figure
    {
        public double Width, Height, Radius;
        public const float Pi = 3.14f;
        public abstract double GetArea();

        protected void test_protested()
        {
            Console.WriteLine("Test");
        }

        public void test()
        {
            Console.WriteLine("Test");
        }
    }

    public class Rectangle : Figure
    {
        public Rectangle(double Width, double Height)
        {
            this.Width = Width;
            this.Height = Height;
        }
        public override double GetArea()
        {
            return Width * Height;
        }

        public void GetTest_protested()
        {
            this.test_protested();
        }
    }
    public class Circle : Figure
    {
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        public override double GetArea()
        {
            return Pi * Radius * Radius;
        }
    }

    public class Triangle : Figure
    {
        public Triangle(double Width, double Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

        public override double GetArea()
        {
            return (Width * Height) / 2;
        }
    }

    public class Cone : Figure
    {
        public Cone(double Radius, double Height)
        {
            this.Radius = Radius;
            this.Height = Height;
        }

        public override double GetArea()
        {
            return Radius * Pi * (Radius + Math.Sqrt(Height * Height + Radius * Radius));
        }
    }

    class TestFigures { 
    
        static void Main()
        {
            Rectangle r = new Rectangle(12.67, 56.78);
            Circle c = new Circle(45.67);
            Cone co = new Cone(34.98, 12.98);
            r.test();
            r.GetTest_protested();
            Console.WriteLine($"Area of Rectangle: {r.GetArea()} ");
            Console.WriteLine($"Area of Circle: {c.GetArea()} ");
            Console.WriteLine($"Area of Cone: {co.GetArea()} ");
            Console.ReadLine();
        }
    
    }
}
