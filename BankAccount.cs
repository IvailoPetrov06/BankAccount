using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        private int id;
        private double balance;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void Deposit(int id, double amount)
        {
            string result = Bank.Deposit(id);
            if (result == "verified")
            {
                Console.WriteLine($"Deposit of {amount:F2} lv. was performed to bank account with ID {Id}.");
                Balance += amount;
            }
            else
            {
                throw new InvalidOperationException("Bank Account does not exist.");
            }
        }

        public void Withdraw(double amount)
        {

            Bank.Withdraw(Balance, amount, Id);

            Console.WriteLine($"Withdraw of {amount:F2} lv. was performed from bank account with ID {Id}.");
            Balance -= amount;


        }

        public BankAccount(int id)
        {
            Id = id;
            Balance = balance;

            Bank.RegisterBankAccount(Id);
        }

        public override string ToString()
        {
            return $"Bank Account Id ({Id}); Balance: {Balance:F2} lv.";
        }
    }
}
