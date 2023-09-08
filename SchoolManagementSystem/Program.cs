using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SchoolManagementSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine("1. Add Students");
            Console.WriteLine("2. Display Students");
            Console.WriteLine("3. Add Teacher");
            Console.WriteLine("4. Display Teacher");
            Console.WriteLine("5. Add Staff");
            Console.WriteLine("6. Display staff");
            Console.WriteLine("7. Exit");
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
                        person.AddStudent();
                        break;
                    case 2:
                        person.DisplayStudent();
                        break;
                    case 3:
                        person.AddTeacher();
                        break;
                    case 4:
                        person.DisplayTeacher();
                        break;
                    case 5:
                        person.AddStaff();
                        break;
                    case 6:
                        person.DisplayStaff();
                        break;
                }
            } while (op > 0 && op < 7);
        }
    }
}
