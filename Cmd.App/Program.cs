using Cmd.App.Academy;
using Cmd.App.Banking;
using Cmd.App.Company;
using Cmd.App.Events;
using Cmd.App.Generics;
using Cmd.App.Shapes;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.Http;

namespace Program
{
    //Method
    //Property
    //Field
    //Nested Types (class, interface, struct, delegates)
    //Events
    //Indexers

    public class Tester
    {
        public static void Main()
        {
            var user = new User()
            {
                LastName = "Prolifik",
                FirstName = "Lexzy"
            };
            Console.WriteLine("End of Main");
        }

        public string MyProperty { get; set; }


    }

    [DebuggerDisplay("Hello {LastName} {FirstName}")]
    public class User
    {
        public string LastName { get; set; }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string FirstName { get; set; }
    }
}
