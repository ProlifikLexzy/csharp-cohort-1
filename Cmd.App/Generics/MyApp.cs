using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.App.Generics
{
    public class MyApp : ITransaction<int, decimal>
    {
        public decimal Credit(decimal amount)
        {
            throw new NotImplementedException();
        }

        public int Debit(int amount)
        {
            throw new NotImplementedException();
        }
    }
}
