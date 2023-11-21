using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment17P1
{
    public class BankAccount
    {
        //readonly int accountNumber;
        //string accountHolderNAme;
        //int balance;
        //int depositAmount;
        //int withdraw;

        //public int AccountNumber
        //{
        //    get { return accountNumber; }
        //}

        //public BankAccount(string name)
        //{
        //    Console.WriteLine("Enter Account Holder's Name is : " + name);
        //    balance = 0;

        //}
        //public void Deposit(int depositAmount)
        //{

        //    balance = depositAmount;
        //}
        //public void Withdraw(int withdraw)
        //{
        //    balance = depositAmount-withdraw;
        //}
        //public int GetBalance()
        //{
        //    Console.WriteLine("Total balence in your Account is : "+balance);
        //    return balance;
        //}



        private static int accountCounter = 1000; // To generate unique account numbers
        private readonly int accountNumber;
        private string accountHolderName;
        private double balance;

        // Properties
        public int AccountNumber
        {
            get { return accountNumber; }
        }

        public string AccountHolderName
        {
            get { return accountHolderName; }
            set { accountHolderName = value; }
        }

        // Balance property is not directly accessible
        public double Balance
        {
            get { return balance; }
        }

        // Constructor
        public BankAccount(string accountHolderName)
        {
            this.accountNumber = GenerateAccountNumber();
            this.accountHolderName = accountHolderName;
            this.balance = 0;
        }

        // Method to deposit money
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited {amount:C}. New balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }


        // Method to withdraw money
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn {amount:C}. New balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
            }
        }

        // Helper method to generate a unique account number
        private int GenerateAccountNumber()
        {
            return ++accountCounter;
        }

    }
}
