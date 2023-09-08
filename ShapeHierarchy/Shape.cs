using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeHierarchy
{
    public abstract class Shape
    {
        public abstract double Area();
        public abstract double Perimeter();
    }
    public class Circle : Shape 
    {
        private int radius;
        private double pi = 3.14;
        public Circle(int r)
        {
            radius= r;
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
        public Triangle(double a, double b, double c)
        {
            AB =a;
            BC =b;
            CA =c;
        }
        public override double Area()
        {
            double S = (AB+BC+CA)/2;
            Console.WriteLine(S);
            return Math.Sqrt(S * (S-AB) * (S-BC) * (S-CA));
        }
        public override double Perimeter()
        {
            return AB+BC+CA;
        }

    }
    public class Rectangle : Shape
    {
        private int width, length;
        public Rectangle(int w, int l)
        {
            width =w;
            length =l;
        }
        public override double Area()
        {
            return width * length;
        }
        public override double Perimeter()
        {
            return 2 * (width+length);
        }

    }
}
