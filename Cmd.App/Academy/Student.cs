using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.App.Academy
{
    public class Student
    {
        public string LastName { get; set; }//implicit propety
        public string FirstName { get; set; }
        public Title Title { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string Matricno { get; set; }
    }
}
