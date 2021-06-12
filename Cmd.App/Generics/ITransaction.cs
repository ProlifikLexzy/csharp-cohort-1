using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.App.Generics
{
    public interface ITransaction<T, H>
    {
        T Debit(T amount);
        H Credit(H amount);
    }
}
