using Cmd.App.Academy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Members
//1. Method
//2. Fields
//3. Property
//4. Event
//5. Nested Class

namespace Cmd.App
{
    public class Instructor
    {
        public Instructor()
        {
            Console.WriteLine("Constructor Called.");
        }

        public Instructor(string instructorId)
        {
            InstructorId = instructorId;
        }

        public Instructor(Info info)
        {
            InstructorId = info.InstructorId;
            LastName = info.LastName;
            FirstName = info.FirstName;
        }

        public string InstructorId { get; set; }
        public string LastName { get; set; }//implicit propety
        public static string FirstName { get; set; } = "Ben";
        public Title Title { get; set; }
        public DateTime DateOfBirth { get; set; }
        public static Gender Gender { get; set; }

        public static void SomeMethod()
        {
            Console.Write(0);
        }

        public class InstuctorCourse
        {
            public string InstructorId { get; set; }
            public string CourseId { get; set; }
        }

    }
}
