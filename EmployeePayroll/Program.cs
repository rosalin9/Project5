using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    public class Program
    {
        static List<Employee> employees = new List<Employee>();
        static void AddEmployee()
        {
            Console.Write("Enter employee ID : ");
            int empID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter employee Name : ");
            string empName = Console.ReadLine();
            Console.Write("Enter employee year of experience : ");
            int empExp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter employee Designation : ");
            string empDesg = Console.ReadLine();
            switch (empDesg)
            {
                case "Manager":
                    Manager manager = new Manager(empID, empName, empExp, empDesg);
                    employees.Add(manager);
                    break;
                case "Developer":
                    Developer developer = new Developer(empID, empName, empExp, empDesg);
                    employees.Add(developer);
                    break;
                case "Tester":
                    Tester tester = new Tester(empID, empName, empExp, empDesg);
                    employees.Add(tester);
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }

        }

        static void EmployeePayroll()
        {
            int Min_PayRate = 3000;
            int Middle_PayRate = 5000;
            int Max_PayRate = 8000;
            double Salary;
            foreach (Employee emp in employees) 
            {
                if(emp.EmpDesignation == "Manager" && emp.EmpExperience >=15)
                {
                    Salary = Max_PayRate + (0.03 * Max_PayRate);
                    Console.WriteLine("Salary of {0} : {1}", emp.EmpName, Salary);
                }
                else if(emp.EmpDesignation == "Manager" && emp.EmpExperience < 15)
                {
                    Salary = Max_PayRate;
                    Console.WriteLine("Salary of {0} : {1}", emp.EmpName, Salary);
                }
                else if(emp.EmpDesignation == "Developer" && (emp.EmpExperience >=8 && emp.EmpExperience <15))
                {
                    Salary = Middle_PayRate + (0.02 * Middle_PayRate);
                    Console.WriteLine("Salary of {0} : {1}", emp.EmpName, Salary);

                }
                else if(emp.EmpDesignation == "Developer" && emp.EmpExperience <8)
                {
                    Salary = Middle_PayRate;
                    Console.WriteLine("Salary of {0} : {1}", emp.EmpName, Salary);
                }
                else if(emp.EmpDesignation == "Tester" && (emp.EmpExperience >= 5 && emp.EmpExperience <8))
                {
                    Salary = Min_PayRate * (0.01 * Min_PayRate);
                    Console.WriteLine("Salary of {0} : {1}", emp.EmpName, Salary);
                }
                else
                {
                    Salary = Min_PayRate;
                    Console.WriteLine("Salary of {0} : {1}", emp.EmpName, Salary);
                }

            }
        }

        static void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee ID    Employee Name        Designation       Experience");
            Console.WriteLine("-----------------------------------------------------------------");
            foreach (Employee emp in employees)
            {
                Console.Write("{0,-20}", emp.EmpID);
                Console.Write("{0,-20}", emp.EmpName);
                Console.Write("{0,-20}", emp.EmpDesignation);
                Console.WriteLine(emp.EmpExperience);
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Employee Information!");
            Console.WriteLine();
            Console.WriteLine("1. Add Employees");
            Console.WriteLine("2. Display Employee details");
            Console.WriteLine("3. Display Salary of Employees");
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
                        AddEmployee();
                        break;
                    case 2:
                        DisplayEmployeeDetails();
                        break;
                    case 3:
                        EmployeePayroll(); 
                        break;
                }
            } while (op > 0 && op < 4);
        }
    }
}
