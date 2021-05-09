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

            switch (input)
            {
                case "f":
                case "F":
                    Console.WriteLine("Is Female");
                    break;
                case "m":
                case "M":
                    Console.WriteLine("Is Male");
                    break;
                case "break":
                    goto exitTag;
                default:
                    Console.WriteLine("UnKnown");
                    break;
            }

            goto tag;
            exitTag:
            Console.WriteLine("End of Main");
        }


    }
}
