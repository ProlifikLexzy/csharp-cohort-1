using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.App.Company
{
    public class User
    {
        public string FullName { get; set; }

        public override string ToString()
        {
            return $"FullName: {FullName}";
        }
    }
}
