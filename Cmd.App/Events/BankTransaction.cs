using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.App.Events
{
    public delegate void TransactionDelegate(TransactionType type, double amount, string account);
    public class BankTransaction
    {
        public event TransactionDelegate TransactionEvent;

        public void DebitCustomer()
        {
            if (TransactionEvent == null)
                return;

            TransactionEvent(TransactionType.DEBIT, 3000, "0343533547"); //Raise Event
        }
    }
}
