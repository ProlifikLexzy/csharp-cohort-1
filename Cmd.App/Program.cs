using Cmd.App;
using Cmd.App.Academy;
using Cmd.Core;
using System;

namespace Program
{
    public class Tester
    {
        public static void Main()
        {
            Console.WriteLine("End of Main");
        }

        public static Application[] GetApplications()
        {
            return new Application[100];
        }
    }
}
