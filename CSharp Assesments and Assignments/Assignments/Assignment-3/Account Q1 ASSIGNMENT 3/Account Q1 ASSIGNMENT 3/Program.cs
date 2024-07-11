using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Q1_ASSIGNMENT_3
{
    public class Accounts
    {
        private int accountNo;
        private string customerName;
        private string accountType;
        private char transactionType;
        private double amount;
        private double balance;

        // Constructor
        public Accounts(int accNo, string name, string accType, char transType)
        {
            accountNo = accNo;
            customerName = name;
            accountType = accType;
            transactionType = transType;
            amount = 0;
            balance = 0;
        }

        // Credit amount to the account
        public void Credit(double amt)
        {
            balance += amt;
        }

        // Debit amount from the account
        public void Debit(double amt)
        {
            if (balance >= amt)
            {
                balance -= amt;
            }
            else
            {
                Console.WriteLine("Insufficient balance!");
            }
        }

        // Update balance based on transaction type
        public void UpdateBalance()
        {
            if (transactionType == 'D' || transactionType == 'd')
            {
                Credit(amount);
            }
            else if (transactionType == 'W' || transactionType == 'w')
            {
                Debit(amount);
            }
            else
            {
                Console.WriteLine("Invalid transaction type!");
            }
        }

        // Display account data
        public void ShowData()
        {
            Console.WriteLine($"Account No: {accountNo}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Account Type: {accountType}");
            Console.WriteLine($"Transaction Type: {transactionType}");
            Console.WriteLine($"Amount: {amount}");
            Console.WriteLine($"Balance: {balance}");
            Console.ReadLine();
        }

        // Main method to demonstrate usage
        public static void Main()
        {
            // Creating an instance of Accounts
            Accounts acc1 = new Accounts(1001, "Raghav Garg", "Savings", 'D');

            // Setting amount for deposit
            acc1.amount = 50000;

            // Updating balance based on transaction type
            acc1.UpdateBalance();

            // Displaying account data
            acc1.ShowData();
        }
    }

}
