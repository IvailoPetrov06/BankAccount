using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Bank
    {
        private static int bankAccountsCount;
        private static List<int> bankAccounts;

        public static List<int> BankAccounts
        {
            get { return bankAccounts; }
            set { bankAccounts = value; }
        }


        public static string Deposit(int id)
        {
            if (BankAccounts.Contains(id))
            {
                //Operation verified
                return "verified";
            }

            return "declined";
        }


        public static void Withdraw(double balance, double amount, int id)
        {
            if (BankAccounts.Contains(id))
            {
                if (amount < 0 || amount > balance)
                {
                    throw new InvalidOperationException("Insufficient balance");

                }
            }
            else
                throw new InvalidOperationException("Account does not exist!");

        }


        static Bank()
        {
            BankAccounts = new List<int>();
        }

        public static void RegisterBankAccount(int id)
        {
            if (bankAccounts.Contains(id))
            {
                throw new InvalidOperationException("Account already exists.");
            }
            else
            {
                bankAccountsCount++;
                bankAccounts.Add(id);
            }

        }
    }
}
