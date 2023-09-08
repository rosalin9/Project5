using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleHierarchy
{
    public abstract class Vehicle
    {
        private string model;
        private string manufacturer;
        private int year;

        public string Model 
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
            set
            {
                manufacturer = value;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        public abstract void Display();
    }
    public class Car : Vehicle
    {
        public override void Display()
        {
            Console.WriteLine("Model of the car is: " + Model);
            Console.WriteLine("Manufacturer of the car is: " + Manufacturer);
            Console.WriteLine("Year of the car is: " + Year);

        }
    }
    public class Bike : Vehicle
    {
        public override void Display()
        {
            Console.WriteLine("Model of the bike is: " + Model);
            Console.WriteLine("Manufacturer of the bike is: " + Manufacturer);
            Console.WriteLine("Year of the bike is: " + Year);

        }
    }
    public class Truck : Vehicle
    {
        public override void Display()
        {
            Console.WriteLine("Model of the truck is: " + Model);
            Console.WriteLine("Manufacturer of the truck  is: " + Manufacturer);
            Console.WriteLine("Year of the truck is: " + Year);

        }
    }
}
