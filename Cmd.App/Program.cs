using Cmd.App;
using Cmd.Core;
using System;

namespace Program
{
    public class Tester
    {
        public static int v = 90;// public global static field
        public static void Main()
        {
            Console.WriteLine("End of Main");
        }

        public static void Method()
        {
            v = 89;
            Console.Write(v);
        }


    }
}
