using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.App.Banking
{
    public class FixedDeposit : IAccount
    {
        public decimal AccountBalance { get; private set; }

        public Currencies Currency { get; set; }

        public decimal OpenAccount(string email)
        {
            return 0;
        }

        public decimal OpenAccount(string email, decimal amount)
        {
            return 0;
        }
    }
}
