using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.App.Banking
{
    public interface ITransaction
    {
        decimal Debit(decimal amount);
        decimal Credit(decimal amount);
    }
}
