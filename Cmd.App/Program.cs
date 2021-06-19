using Cmd.App.Banking;
using Cmd.App.Company;
using Cmd.App.Events;
using Cmd.App.Generics;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Program
{

    //Method
    //Property
    //Field
    //Nested Types (class, interface, struct, delegates)
    //Events
    //Indexers
    public class Tester
    {
        public delegate int MyDelegate(int i);
        public static void Main()
        {

            MyDelegate myDelegate = (param1) => { return 85; };
            MyDelegate myDelegate2 = param1 => { return 85; };
            MyDelegate myDelegate3 = param1 => 85;
            MyDelegate myDelegate4 = myDelegate;

            var o = new { LastName = "" };

            BankTransaction bankTransaction = new();
            bankTransaction.TransactionEvent += new TransactionDelegate(RespondToDebit);
            bankTransaction.TransactionEvent += EmailManager.SendEmailAlert;
            bankTransaction.TransactionEvent += (type, amount, customerNo) =>
            {

            };

            bankTransaction.DebitCustomer();

            Console.WriteLine("End of Main");
        }

        public static void RespondToDebit(TransactionType type, double amount, string customerNo)
        {
            Console.WriteLine("{0} of {1:n2} occured on customer account ({2})", type, amount, customerNo);
        }

        public static void SendSmsAlert(TransactionType type, double amount, string customerNo)
        {
            Console.WriteLine("Sms Alert");
        }
    }

    public class EmailManager
    {
        public static void SendEmailAlert(TransactionType type, double amount, string customerNo)
        {
            Console.WriteLine("Email Alert");
        }
    }


}
