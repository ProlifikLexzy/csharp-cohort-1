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
    public class ester
    {
        public delegate int MyDelegate(int i);
        public static void Main()
        {



            Square s = new Square();
            DateTime? dateTime;
            Nullable<bool> d = null;
            bool? age = d;

            if (age.HasValue)
            {
                Console.WriteLine(age.Value);
            }

            // Null Coalescing
            bool? isSingle = null;

            var defaultMessage = "Marriage status not selected";
            var marriedMessage = "You're married";
            var singleMessage = "You're single";
            string message = isSingle.HasValue ? (isSingle.Value ? marriedMessage : singleMessage) : defaultMessage; // Tenary operator


            
            Console.WriteLine(message);

           string somevalue = null;

            var m = somevalue ?? "[NA]";
            Console.WriteLine(m);

            Console.WriteLine("End of Main");
        }

    }
}
