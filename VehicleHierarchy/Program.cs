using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleHierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Car Details");
            Console.WriteLine("2. Bike Details");
            Console.WriteLine("3. Truck Details");
            Console.WriteLine("4. Exit");
            Console.WriteLine();
            int op;
            do
            {
                
                Console.Write("Enter your choice: ");
                op = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (op)
                {
                    case 1:
                        Car vehicle1 = new Car();
                        vehicle1.Model = "S";
                        vehicle1.Manufacturer = "TESLA";
                        vehicle1.Year = 2023;
                        vehicle1.Display();
                        break;
                    case 2:
                        Bike vehicle2 = new Bike();
                        vehicle2.Model = "ROAD GLIDE";
                        vehicle2.Manufacturer = "Harley Davidson";
                        vehicle2.Year = 2023;
                        vehicle2.Display();
                        break;
                    case 3:
                        Truck vehicle3 = new Truck();
                        vehicle3.Model = "F-150 XL";
                        vehicle3.Manufacturer = "Ford";
                        vehicle3.Year = 2020;
                        vehicle3.Display();
                        break;

                }
            } while (op > 0 && op < 4);
            
           
        }
    }
}
