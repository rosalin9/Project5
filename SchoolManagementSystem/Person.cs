using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    public class Person
    {
        protected string Name;
        protected int Age;
        protected string Gender;


        List<Student> students = new List<Student>();
        List<Teacher> teachers = new List<Teacher>();
        List<Staff> staffs = new List<Staff>();

        public void AddStudent()
        {
            Console.Write("Enter the student name: ");
            Name = Console.ReadLine();
            Console.Write("Enter the student age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the student gender: ");
            Gender = Console.ReadLine();
            Student s = new Student(Name, Age, Gender);
            Console.Write("Enter the student branch: ");
            s.Branch = Console.ReadLine();
            Console.Write("Enter the student mark: ");
            s.Mark = Convert.ToInt32(Console.ReadLine());
            students.Add(s);
        }

        public void DisplayStudent()
        {
            Console.WriteLine("Student Name       Age     Gender    Branch     Mark");
            Console.WriteLine("-----------------------------------------------------");
            foreach (Student stu in students)
            {
                Console.Write("{0,-20}", stu.Name);
                Console.Write("{0,-10}", stu.Age);
                Console.Write("{0,-10}", stu.Gender);
                Console.Write("{0,-10}", stu.Branch);
                Console.WriteLine(stu.Mark);
            }
            Console.WriteLine();
        }

        public void AddTeacher()
        {
            Console.Write("Enter the teacher name: ");
            Name = Console.ReadLine();
            Console.Write("Enter the teacher age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the teacher gender: ");
            Gender = Console.ReadLine();
            Teacher t = new Teacher(Name, Age, Gender);
            Console.Write("Enter the teacher department: ");
            t.Dept = Console.ReadLine();
            teachers.Add(t);
        }

        public void DisplayTeacher()
        {
            Console.WriteLine("Teacher Name        Age     Gender    Department");
            Console.WriteLine("-------------------------------------------------");
            foreach (Teacher tec in teachers)
            {
                Console.Write("{0,-20}", tec.Name);
                Console.Write("{0,-8}", tec.Age);
                Console.Write("{0,-10}", tec.Gender);
                Console.WriteLine(tec.Dept);
            }
            Console.WriteLine();
        }

        public void AddStaff()
        {
            Console.Write("Enter the staff name: ");
            Name = Console.ReadLine();
            Console.Write("Enter the staff age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the staff gender: ");
            Gender = Console.ReadLine();
            Staff st = new Staff(Name, Age, Gender);
            Console.Write("Enter the staff type: ");
            st.StaffType = Console.ReadLine();
            staffs.Add(st);
        }

        public void DisplayStaff()
        {
            Console.WriteLine("Staff Name         Age     Gender     Staff Type");
            Console.WriteLine("------------------------------------------------");
            foreach (Staff stf in staffs)
            {
                Console.Write("{0,-20}", stf.Name);
                Console.Write("{0,-10}", stf.Age);
                Console.Write("{0,-10}", stf.Gender);
                Console.WriteLine(stf.StaffType);
            }
            Console.WriteLine();
        }
    }
    public class Student : Person
    {
        public int Mark{ get; set; }
        public string Branch{ get; set; }
        public Student(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        
    }
    public class Teacher : Person
    {
        public string Dept { get; set; }
        public Teacher(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
    }
    public class Staff : Person
    {
        public string StaffType { get; set; }
        public Staff(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

    }
}
