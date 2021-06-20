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
        public int Age { get; set; }

        public static User operator +(User first, User second)
        {
            return new User() { Age = first.Age + second.Age };
        }

        public static bool operator >(User first, User second)
        {
            return first.Age > second.Age;
        }

        public static bool operator <(User first, User second)
        {
            return first.Age < second.Age;
        }
        public static bool operator ==(User first, User second)
        {
            return first.FullName == second.FullName;
        }

        public static bool operator !=(User first, User second)
        {
            return first.FullName != second.FullName;
        }

        public override string ToString()
        {
            return $"FullName: {FullName} Age: {this.Age}";
        }
    }
}
