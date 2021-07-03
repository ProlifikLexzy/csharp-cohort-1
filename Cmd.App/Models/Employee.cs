using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.App.Models
{
    public class Employee : BaseEntity
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
}
