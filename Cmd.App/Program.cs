using Cmd.App;
using System;

namespace Program
{
    public class Tester
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToUpper();

            //switch pattern matching
            string answer = input switch
            {
                "F" => "Is Female",
                "M" => "Is Male",
                "break" => "break",
                _ => "UnKnown"
            };

            Console.WriteLine(answer);
            Console.WriteLine("End of Main");
        }


    }
}
