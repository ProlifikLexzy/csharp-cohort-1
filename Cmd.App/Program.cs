using Cmd.App.Academy;
using Cmd.App.Banking;
using Cmd.App.Company;
using Cmd.App.Events;
using Cmd.App.Generics;
using Cmd.App.Shapes;
using System;
using System.Collections;
using System.Collections.Generic;

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
        public delegate int MyDelegate(int i);
        public static void Main()
        {
            var u1 = new User() { FullName = "Segun Ojo", Age = 20 };
            var u2 = new User() { FullName = "Segun Ojo", Age = 89};
             var result = --u2;

            

            Console.WriteLine(result);

            Console.WriteLine("End of Main");
        }

    }
}
