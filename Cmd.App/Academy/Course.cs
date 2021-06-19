using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.App.Academy
{
    public class Course
    {
        public string Title { get; set; }
        public string Code { get; set; }
        public int? Unit { get; set; }
        public Duration Duration { get; set; }
    }
}
