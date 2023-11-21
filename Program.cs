using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment17P1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //BankAccount b = new BankAccount("Jhon");
            //b.GetBalance();
            //b.Deposit(1000);
            //b.GetBalance();
            //b.Withdraw(50);
            //b.GetBalance();

            BankAccount myAccount = new BankAccount("John Doe");

            Console.WriteLine($"Account Number: {myAccount.AccountNumber}");
            Console.WriteLine($"Account Holder: {myAccount.AccountHolderName}");
            Console.WriteLine($"Initial Balance: {myAccount.Balance:C}");

            myAccount.Deposit(1000);
            myAccount.Withdraw(500);


            Console.ReadKey();
        }
    }
}
