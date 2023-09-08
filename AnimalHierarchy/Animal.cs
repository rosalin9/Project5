using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Animal
    {
        public string Name;
        public string Type;
        public string Sound;

        void Display()
        {
            Console.WriteLine("Details of all the animals");
        }

    }
    public class Dog : Animal 
    {
        public Dog(string name, string type, string sound)
        {
            Name = name;
            Type = type;
            Sound = sound;
        }

        public void Display()
        {
            Console.WriteLine("Dog Name: " +  Name);
            Console.WriteLine("Dog Type: " +  Type);
            Console.WriteLine("Dog Sound: " +  Sound);
        }
    }
    public class Cat : Animal
    {
        public Cat(string name, string type, string sound)
        {
            Name = name;
            Type = type;
            Sound = sound;
        }

        public void Display()
        {
            Console.WriteLine("Cat Name: " + Name);
            Console.WriteLine("Cat Type: " + Type);
            Console.WriteLine("Cat Sound: " + Sound);
        }
    }
    public class Bird : Animal
    {
        public Bird(string name, string type, string sound)
        {
            Name = name;
            Type = type;
            Sound = sound;
        }

        public void Display()
        {
            Console.WriteLine("Bird Name: " + Name);
            Console.WriteLine("Bird Type: " + Type);
            Console.WriteLine("Bird Sound: " + Sound);
        }
    }
}
