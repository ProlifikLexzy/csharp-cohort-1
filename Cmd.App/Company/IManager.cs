using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.App.Company
{
    public interface IManager<T>
    {
        void Create(T item);
        void Update(T item);
        void Save(T item);
        void Delete(int id);
    }
}
