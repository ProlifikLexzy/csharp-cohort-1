using Cmd.App;
using Cmd.App.Academy;
using Cmd.App.Automobile;
using Cmd.App.Messaging;
using Cmd.App.Shapes;
using Cmd.App.Storages;
using Cmd.Core;
using System;

namespace Program
{
    public class Tester
    {
        public static void Main()
        {
            ISmsProvider smsProvider = new Infopib();


            Console.WriteLine("End of Main");
        }
    }
}
