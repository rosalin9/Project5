using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeHierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Detail Information");
            Console.WriteLine();
            Console.WriteLine("1. Display Manager Details");
            Console.WriteLine("2. Display Developer Details");
            Console.WriteLine("3. Display Tester Details");
            Console.WriteLine("4. Exit");

            Console.WriteLine();
            Manager employee1 = new Manager(101, "Rahul Kumar", "Senior Project Manager");
            Developer employee2 = new Developer(105, "Pooja Dixit", "Software Developer");
            Tester employee3 = new Tester(109, "Rajiv Chaudhury", "Manual Tester");
            int op;

            do
            {
                Console.Write("Enter your choice: ");
                op = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (op)
                {
                    case 1:
                        employee1.DisplayDetails();
                        break;
                    case 2:
                        employee2.DisplayDetails();
                        break;
                    case 3:
                        employee3.DisplayDetails();
                        break;
                   
                }
            } while (op > 0 && op < 4);

        }
    }
}
