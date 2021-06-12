using Cmd.App.Banking;
using Cmd.App.Generics;
using System;

namespace Program
{
    public class Tester
    {
        public static void Main()
        {
            Object o = new();
            
           

            var account = new SavingAccount();
            account.Currency = Currencies.NAIRA;

            var account2 = new SavingAccount()
            {
                Currency = Currencies.NAIRA
            };

            dynamic d = new
            {
                anything = 899,
                Lastname = "iueuureure",
                Currencies = account.Currency
            };

            Console.WriteLine(d.Lastname);

            var arithmetic = new Arithmetic<int, double>();
            var arithmetic2 = new Arithmetic<bool, string>();

            SavingAccount txn = new();

            var acc = txn as IAccount;
            if (acc != null)
                acc.Credit(90);


            //if (txn is IAccount account)
            //    account.Credit(90);

            Console.WriteLine("End of Main");
        }
    }
}
