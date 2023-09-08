using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeHierarchy
{
    public class Employees
    {
        public int EmpID;
        public string EmpName;
        public string EmpDesignation;

        void DisplayDetails()
        {
            Console.WriteLine("Details of all the Employees");
        }
    }
    public class Manager : Employees
    {
        public Manager(int empID, string empName, string empDesignation)
        {
            EmpID = empID;
            EmpName = empName;
            EmpDesignation = empDesignation;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Employee ID: {EmpID}");
            Console.WriteLine($"Employee Name: {EmpName}");
            Console.WriteLine($"Employee Designation: {EmpDesignation}");
        }
    }
    public class Developer : Employees
    {
        public Developer(int empID, string empName, string empDesignation)
        {
            EmpID = empID;
            EmpName = empName;
            EmpDesignation = empDesignation;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Employee ID: {EmpID}");
            Console.WriteLine($"Employee Name: {EmpName}");
            Console.WriteLine($"Employee Designation: {EmpDesignation}");
        }
    }
    public class  Tester : Employees
    {
        public Tester(int empID, string empName, string empDesignation)
        {
            EmpID = empID;
            EmpName = empName;
            EmpDesignation = empDesignation;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Employee ID: {EmpID}");
            Console.WriteLine($"Employee Name: {EmpName}");
            Console.WriteLine($"Employee Designation: {EmpDesignation}");
        }
    }
}
