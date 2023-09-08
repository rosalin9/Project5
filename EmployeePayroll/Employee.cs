using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    public class Employee
    {
        public int EmpID;
        public string EmpName;
        public int EmpExperience;

        public string EmpDesignation;

        
    }
    public class Manager : Employee
    {
        public Manager(int empID, string empName, int empExperience, string empDesignation)
        {
            EmpID = empID;
            EmpName = empName;
            EmpExperience = empExperience;
            EmpDesignation = empDesignation;
        }
       
    }
    public class Developer : Employee
    {
        public Developer(int empID, string empName, int empExperience, string empDesignation)
        {
            EmpID = empID;
            EmpName = empName;
            EmpExperience = empExperience;
            EmpDesignation = empDesignation;
        }
        
    }
    public class Tester : Employee
    {
        public Tester(int empID, string empName, int empExperience, string empDesignation)
        {
            EmpID = empID;
            EmpName = empName;
            EmpExperience = empExperience;
            EmpDesignation = empDesignation;
        }
        
    }
}
