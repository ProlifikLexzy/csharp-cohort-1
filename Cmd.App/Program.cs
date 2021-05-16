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


            Application[] v = GetApplications();

            for (var i = 0; i < v.Length; i++)
            {
                v[i] = new Application();
            }

            for (var i = 0; i < v.Length; i++)
            {
                var application = v[i];
                application.Approve();
            }

            //Console.WriteLine("End of Main");
        }

        public static Application[] GetApplications()
        {
            return new Application[100];
        }
    }
}
