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
            int i = 90;
            Console.WriteLine(i);
            var v = 0;
            v = v / i;
            Console.WriteLine(v);

            var result = (0 <= v || true);
            Console.WriteLine(result);

            Console.WriteLine("End of Main");
        }

        public static Application[] GetApplications()
        {
            return new Application[100];
        }
    }
}
