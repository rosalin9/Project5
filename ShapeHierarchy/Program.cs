using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeHierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle: ");
            int r = Convert.ToInt32(Console.ReadLine());
            Shape circle = new Circle(r);
            Console.WriteLine();
            Console.WriteLine("Area of the circle is: " + circle.Area());
            Console.WriteLine("Perimeter of the circle is: " + circle.Perimeter());
            Console.WriteLine();
            Console.Write("Enter the 3 sides of the triangle: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            Shape triangle = new Triangle(a, b, c);
            Console.WriteLine();
            Console.WriteLine("Area of the triangle is: " + triangle.Area());
            Console.WriteLine("Perimeter of the triangle is: " + triangle.Perimeter());
            Console.WriteLine();
            Console.Write("Enter the Width and Length of the rectangle: ");
            int w = Convert.ToInt32(Console.ReadLine());
            int l = Convert.ToInt32(Console.ReadLine());
            Shape rectangle = new Rectangle(w, l);
            Console.WriteLine();
            Console.WriteLine("Area of the rectangle is: " + rectangle.Area());
            Console.WriteLine("Perimeter of the rectangle is: " + rectangle.Perimeter());
            Console.Read();
        }
    }
}
