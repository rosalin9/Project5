using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Animals Detail");
            Console.WriteLine();
            Console.WriteLine("1. Display Dog Details");
            Console.WriteLine("2. Display Cat Details");
            Console.WriteLine("3. Display Bird Details");
            Console.WriteLine("4. Exit");

            Console.WriteLine();
            Dog animal1 = new Dog("Bruno","Labrador","Woof Woof");
            Cat animal2 = new Cat("Bella", "Persian", "Meow Meow");
            Bird animal3 = new Bird("Angel", "Parrot", "Squawk Squawk");
            int op;

            do
            {
                Console.Write("Enter your choice: ");
                op = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (op)
                {
                    case 1:
                        animal1.Display();
                        break;
                    case 2:
                        animal2.Display();
                        break;
                    case 3:
                        animal3.Display();
                        break;

                }
            } while (op > 0 && op < 4);

        }
    }
}
