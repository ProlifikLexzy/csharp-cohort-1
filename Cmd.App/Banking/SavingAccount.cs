using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.App.Banking
{
    public class SavingAccount : IAccount, ITransaction
    {
        public decimal AccountBalance { get; private set; } // read-only property
        public Currencies Currency { get; set; }


        public decimal Credit(decimal amount)
        {
            if (amount <= 0)
                return 0;

            this.AccountBalance += amount;
            return this.AccountBalance;
        }

        decimal IAccount.Credit(decimal amount)
        {
            return this.Credit(amount);
        }

        public decimal Debit(decimal amount)
        {
            this.AccountBalance -= amount;
            return this.AccountBalance;
        }

        //Explicit interface implementation
        decimal IAccount.Debit(decimal amount)
        {
            return Debit(amount);
        }

        public decimal OpenAccount(string email)
        {
            return 0;
        }

        public decimal OpenAccount(string email, decimal amount)
        {
            this.AccountBalance = amount;
            Console.WriteLine("Customer Account Created with opening balance {0}", amount);
            return this.AccountBalance;
        }
    }
}
