using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountHierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Online Banking System");
            Console.WriteLine();
            Console.WriteLine("1. Savings Account Deposit");
            Console.WriteLine("2. Savings Account Withdrawal");
            Console.WriteLine("3. Display Savings Account Details");
            Console.WriteLine("4. Current Account Deposit");
            Console.WriteLine("5. Current Account Withdrawal");
            Console.WriteLine("6. Display Current Account Details");
            Console.WriteLine("7. Exit");

            Console.WriteLine();
            
            SavingsAccount account1 = new SavingsAccount(50000, 000001010119234, "Rosalin Mahapatra");            
            CurrentAccount account2 = new CurrentAccount(60000, 000001010119234, "Rosalin Mahapatra");
            int op;

            do
            {

                Console.Write("Enter your choice: ");
                op = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (op)
                {
                    case 1:                        
                        account1.Deposit();
                        break;
                    case 2:             
                        account1.Withdraw();
                        break;
                    case 3:                        
                        account1.DisplayAccount();
                        break;
                    case 4:                        
                        account2.Deposit();
                        break;
                    case 5:
                        account2.Withdraw();
                        break;
                    case 6:
                        account2.DisplayAccount();
                        break;
                   
                }
            } while (op > 0 && op < 7);

        }
    }
}
