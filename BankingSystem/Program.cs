using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class Program
    {
              
        static void Main(string[] args)
        {
            Bank bank = new Bank(); 
            Console.WriteLine("Welcome to Banking System!");
            Console.WriteLine();
            Console.WriteLine("1. Add Customers");
            Console.WriteLine("2. Display Customers");
            Console.WriteLine("3. Deposit in a account");
            Console.WriteLine("4. Withdraw from a account");
            Console.WriteLine("5. Transfer amount from one account to other account");
            Console.WriteLine("6. Exit");
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
                        bank.AddCustomers();
                        break;
                    case 2:
                        bank.DisplayCustomers();
                        break;
                    case 3:
                        Console.Write("Enter the account number to which you want to add the amount : ");
                        int Acc_Number = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter the amount to be deposited : ");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        foreach (var account in bank.accounts)
                        {
                            if (account.Account_Number == Acc_Number)
                            {
                                account.Deposit(amount);
                            }
                            else
                                Console.WriteLine("Account doesnot Exist");
                        }
                        break;
                    case 4:
                        Console.Write("Enter the account number from which you want to withdraw the amount : ");
                        int Acc_Number1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter the amount to withdraw : ");
                        int amount1 = Convert.ToInt32(Console.ReadLine());
                        foreach (var account in bank.accounts)
                        {
                            if (account.Account_Number == Acc_Number1)
                            {
                                account.Withdraw(amount1);
                            }
                            else
                                Console.WriteLine("Account doesnot Exist");
                        }
                        break;
                    case 5:
                        Console.Write("Enter the account number from which you want to transfer the amount : ");
                        int Acc_Number2 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter the account number to which account you want to transfer : ");
                        int Acc_Number3 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter the amount you to transfer : ");
                        int amount2 = Convert.ToInt32(Console.ReadLine());
                        foreach (var account in bank.accounts)
                        {
                            if (account.Account_Number == Acc_Number2)
                            {
                                account.Withdraw(amount2);

                            }
                            else if (account.Account_Number == Acc_Number3)
                            {
                                account.Transfer(amount2, Acc_Number2);
                                break;
                            }

                        }
                        break;
                }
            } while (op > 0 && op < 6);
        }
    }
}
