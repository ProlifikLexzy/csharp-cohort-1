using Cmd.App;
using System;

namespace Program
{
    public class Tester
    {
        public static void Main()
        {
        tag:
            var input = Console.ReadLine();

            if (input == "f")
                Console.WriteLine("Is Female");
            else if (input == "F")
                Console.WriteLine("Is Female");
            else if (input == "m")
                Console.WriteLine("Is Male");
            else if (input == "M")
                Console.WriteLine("Is Male");
            else
                Console.WriteLine("UnKnown");

            goto tag;
            //Console.WriteLine("End of Main");
        }


    }
}
