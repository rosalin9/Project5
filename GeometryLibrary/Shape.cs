using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{

    public abstract class Shape
    {
        public string ShapeName;
        public abstract double Area();
        public abstract double Perimeter();
    }

    public class Circle : Shape
    {
        private int radius;
        private double pi = 3.14;
        public Circle(int r, string shapeName)
        {
            radius = r;
            this.ShapeName = shapeName;
        }
        public override double Area()
        {
            return pi * radius * radius;
        }
        public override double Perimeter()
        {
            return 2 * pi * radius;
        }
    }


    public class Triangle : Shape
    {
        private double AB, BC, CA;
        public Triangle(double a, double b, double c, string shapeName)
        {
            AB = a;
            BC = b;
            CA = c;
            this.ShapeName = shapeName;
        }
        public override double Area()
        {
            double S = (AB + BC + CA) / 2;
            return Math.Sqrt(S * (S - AB) * (S - BC) * (S - CA));
        }
        public override double Perimeter()
        {
            return AB + BC + CA;
        }
    }


    public class Rectangle : Shape
    {
        private int width, length;
        public Rectangle(int w, int l, string shapeName)
        {
            width = w;
            length = l;
            this.ShapeName = shapeName;
        }
        public override double Area()
        {
            return width * length;
        }
        public override double Perimeter()
        {
            return 2 * (width + length);
        }
    }
    
}
