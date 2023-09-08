using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountHierarchy
{
    interface IBankAccount
    {

        void Deposit();
        void Withdraw();

        void DisplayAccount();

    }

    //public class BankAccount
    //{
    //    private int account_Number;
    //    public string account_Name;
                
    //    public string AccountName
    //    {
    //        get { return account_Name; }
    //        set { account_Name = value; }
    //    }
    //    public int AccountNumber
    //    {
    //        get { return account_Number; }
    //        set { account_Number = value; }
    //    }
    //    public void Deposit()
    //    {
    //        Console.WriteLine("This is the deposit method");
    //    }
    //    public void Withdraw()
    //    {
    //        Console.WriteLine("This is the withdraw method");
    //    }
    //    public void DisplayAccount()
    //    {
    //        Console.WriteLine("This is the display method");
    //    }
    //}
    class SavingsAccount : IBankAccount
    {
        private int Balance;
        private int AccountNumber;
        private string AccountName; 

        int amount;
        int Withdraw_Limit = 5000;
        
        public SavingsAccount(int balance, int account_Number, string account_Name)
        {
            Balance = balance;
            AccountNumber = account_Number;
            AccountName = account_Name;
            
        }

        public void Deposit()
        {
            
            Console.Write("Enter the amount to be deposited : ");
            amount = Convert.ToInt32(Console.ReadLine());
            Balance += amount;
        }
        public void Withdraw()
        {
            Console.Write("Enter the amount to be withdraw : ");
            amount = Convert.ToInt32(Console.ReadLine());
            
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else if(amount > Withdraw_Limit)
            {
                Console.WriteLine("Entered amount exceeds the withdrawl limit of this Savings Account");
            }
            else
            {
                Balance -= amount;
                Withdraw_Limit -= amount;
                Console.WriteLine("Collect your amount {0}", amount);
            }
        }
        public void DisplayAccount()
        {
            
            Console.WriteLine("Account Number : " + AccountNumber);
            Console.WriteLine("Account Name : " + AccountName);
            Console.WriteLine("Account Balance : " + Balance);
        }



    }
    public class CurrentAccount : IBankAccount
    {

        private int Balance;
        private int AccountNumber;
        private string AccountName;

        int amount;
        
        public CurrentAccount(int balance, int account_Number, string account_Name)
        {
            Balance = balance;
            AccountNumber = account_Number;
            AccountName = account_Name;
        }

        public void Deposit() 
        {
            Console.Write("Enter the amount to be deposited : ");
            amount = Convert.ToInt32(Console.ReadLine());
            Balance += amount;
        }
        public void Withdraw() 
        {
            Console.Write("Enter the amount to be withdraw : ");
            amount = Convert.ToInt32(Console.ReadLine());
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                Balance -= amount;
            }
        }
        public void DisplayAccount()
        {
            Console.WriteLine("Account Number : " + AccountNumber);
            Console.WriteLine("Account Name : " + AccountName);
            Console.WriteLine("Account Balance : " + Balance);

        }

    }
}
