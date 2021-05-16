using Cmd.App;
using Cmd.App.Academy;
using Cmd.Core;
using System;

namespace Program
{
    public class Tester
    {
        public static int v = 90;// public global static field
        public static void Main()
        {

            var instuctorCourse = new Instructor.InstuctorCourse();
            var instructor = new Instructor("004054-PL");
            Console.WriteLine("First Name: {0}", Instructor.FirstName);

            Instructor.FirstName = "Jide";

            var info = new Info();
            var instructor2 = new Instructor(info);
            Console.WriteLine("First Name: {0}", Instructor.FirstName);
            
            Console.WriteLine("End of Main");
        }



    }
}
