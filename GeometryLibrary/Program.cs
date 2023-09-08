using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    public class Program
    {
        static List<Shape> shapes = new List<Shape>();

        static void AddShapes()
        {
                        
            Console.Write("Enter Shape (Circle/Triangle/Rectangle) : ");
            string shape = Console.ReadLine();
            switch (shape)
            {
                case "Circle":
                    Console.Write("Enter Circle Radius : ");
                    int radius = Convert.ToInt32(Console.ReadLine());
                    Circle circle = new Circle(radius,shape);
                    shapes.Add(circle);
                    break;
                case "Triangle":
                    Console.Write("Enter the 3 sides of the triangle: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    double b = Convert.ToDouble(Console.ReadLine());
                    double c = Convert.ToDouble(Console.ReadLine());
                    Triangle triangle = new Triangle(a, b, c, shape);
                    shapes.Add(triangle);
                    break;
                case "Rectangle":
                    Console.Write("Enter the Width and Length of the rectangle: ");
                    int w = Convert.ToInt32(Console.ReadLine());
                    int l = Convert.ToInt32(Console.ReadLine());
                    Rectangle rectangle = new Rectangle(w, l, shape);
                    shapes.Add(rectangle);
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }

        static void FindLargestShape()
        {
            Shape Obj = shapes[0];
            Shape largest = Obj;

            foreach(Shape shape in shapes)
            {
                if(Obj.Area() < shape.Area())
                    largest = shape;
            }

            Console.WriteLine("Largest shape in the list is {0} with Area {1}",largest.ShapeName, largest.Area());
        }
        static void DisplayShapes()
        {
            Console.WriteLine("Shape          Area      Perimeter");
            Console.WriteLine("-----------------------------------");
            foreach (Shape shape in shapes) 
            {
                if (shape.ShapeName == "Circle")
                {
                    Console.Write("{0,-15}",shape.ShapeName);
                    Console.Write("{0,-10}", shape.Area());
                    Console.WriteLine(shape.Perimeter());
                }
                else if(shape.ShapeName == "Triangle")
                {
                    Console.Write("{0,-15}", shape.ShapeName);
                    Console.Write("{0,-10}", shape.Area());
                    Console.WriteLine(shape.Perimeter());
                }
                else
                {
                    Console.Write("{0,-15}", shape.ShapeName);
                    Console.Write("{0,-10}", shape.Area());
                    Console.WriteLine(shape.Perimeter());
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1. Add Shapes");
            Console.WriteLine("2. Display Shapes");
            Console.WriteLine("3. Find largest shape");
            Console.WriteLine("4. Exit");
            Console.WriteLine();
            int op;
            do
            {
                Console.WriteLine();
                Console.Write("Enter your choice: ");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        AddShapes();
                        break;
                    case 2:
                        DisplayShapes();
                        break;
                    case 3:
                        FindLargestShape(); 
                        break;
                }
            } while (op > 0 && op < 4);
        }
    }
}
