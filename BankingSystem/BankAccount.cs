using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class Bank
    {
        public List<Account> accounts = new List<Account>();
             
        public void AddCustomers()
        {
            Console.Write("Enter the customer account number: ");
            int accNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the customer name: ");
            string CustName = Console.ReadLine();

            Console.Write("Enter the customer ID: ");
            int CustID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the balance: ");
            int balance = Convert.ToInt32(Console.ReadLine());

            Customer customerObj = new Customer(CustName,CustID);

            accounts.Add(new Account(accNumber, balance, customerObj));
        }

        public void DisplayCustomers()
        {
            Console.WriteLine("Account Number    Customer ID     Customer Name        Balance");
            Console.WriteLine("---------------------------------------------------------------------");
            foreach (Account account in accounts)
            {
                Console.Write("{0,-20}", account.Account_Number);
                Console.Write("{0,-15}", account._customer.Customer_ID);
                Console.Write("{0,-20}", account._customer.Customer_Name);
                Console.WriteLine(account.Balance);
            }
        }

    }
    public class Account 
    {
        public int Account_Number { get; }
        public int Balance;
        public Customer _customer;
        
        public Account(int accNumber, int balance, Customer customer) 
        {
            Account_Number = accNumber;
            Balance = balance;
            _customer = customer;
            
        }
        public void Deposit(int amount)
        {
            
            Balance += amount;

        }
        public void Withdraw(int amount)
        {
            
            if (amount > Balance)
            { 
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                Balance -= amount;
                
            }
        }
        public void Transfer(int amount, int AccNumber)
        {
            Balance += amount;
            Console.WriteLine("{0} Rs transfer to your account from account {1}", amount, AccNumber);
        }

    }
    public class Customer
    {
        public string Customer_Name { get; }
        public int Customer_ID { get; }
        public Customer(string customerName, int customerID) 
        {
            Customer_Name = customerName;
            Customer_ID = customerID;
        }
    }
}
