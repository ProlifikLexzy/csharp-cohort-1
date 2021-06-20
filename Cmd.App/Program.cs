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
            foreach (var item in GetUsers())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("End of Main");
        }

        public static IEnumerable<string> GetNames()
        {
           
            //var userArray = new string[]
            //{
            //     "Prolifik Lexzy",
            //    "Scott Hanselman",
            //    "Scott Hunter",
            //    "Scott Guthrie"
            //};

            yield return "Prolifik Lexzy";
            yield return "Scott Hanselman";
            yield return "Scott Hunter";
            yield return "Scott Hunter";
        }

        public static IEnumerable<User> GetUsers()
        {
            var names = new string[]
            {
                 "Prolifik Lexzy",
                "Scott Hanselman",
                "Scott Hunter",
                "Scott Guthrie"
            }; ;

            //foreach (var name in names)
            //{
            //    yield return new User() { FullName = name };
            //}


            for (int i = 0; i < names.Length; i++)
            {
                yield return new User() { FullName = names[i] };
            }

            yield return new User() { FullName = "Funke Akindele"};

        }

    }
}
