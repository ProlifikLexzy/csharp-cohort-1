using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.App.Banking
{
    public interface IAccount 
    {
        decimal OpenAccount(string email);
        decimal OpenAccount(string email, decimal amount);
        decimal AccountBalance { get; }
        Currencies Currency { get; set; }
        decimal Debit(decimal amount);
        decimal Credit(decimal amount);
    }
}
