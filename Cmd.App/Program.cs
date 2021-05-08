using Cmd.App;
using Cmd.Core;
using System;

namespace Program
{
    public class Tester
    {
        public static void Main()
        {
            

            ArithmeticCalculator.Add(1.9, 1, 7);
            ArithmeticCalculator.Add(second: 1, first: 1.8, third: 7);

            var lastName = "Bob";
            var firstName = "Tabor";
            firstName = lastName;
            Console.WriteLine("{0} {1}", firstName, lastName);
            firstName = "Tabor";
            Console.WriteLine("{0} {1}", firstName, lastName);

            var variable = 4.0999; // implicit typing. literal assignment
            var v2 = 90;

            Console.WriteLine("{0} {1}", variable, v2);
            v2 = 1000;
            Console.WriteLine("{0} {1}", variable, v2);
        }
    }
}
