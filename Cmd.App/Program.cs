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
            //IEnumerable
            var users = new Users() { };

            foreach (var user in users)
            {
                Console.WriteLine(user);
            }

            var numbers = new Int32[6] { 1, 2, 3, 4, 5, 6 };
            var enumerator = numbers.GetEnumerator();

            for (int i = 0; i < numbers.Length; i++)
            {
                enumerator.MoveNext();
                Console.WriteLine(enumerator.Current);
            }

            //enumerator.Reset();
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (enumerator.MoveNext())
                {
                    Console.WriteLine(enumerator.Current);
                }
            }


            Console.WriteLine("End of Main");
        }

    }
}
