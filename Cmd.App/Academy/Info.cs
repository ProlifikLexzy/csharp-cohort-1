using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.App.Academy
{
    public class Info
    {
        public string InstructorId { get; set; }
        public string LastName { get; set; }
        public  string FirstName { get; set; }
        public Title Title { get; set; }
        public DateTime DateOfBirth { get; set; }
        public static Gender Gender { get; set; }
    }
}
