using Cmd.App;
using System;

namespace Program
{
    public class Tester
    {
        public static void Main()
        {
            //Unconditional Branch Statement
            SomeMethod();
            Console.WriteLine("End of Main");
        }

        public static void SomeMethod()
        {
            int x;
            x = 18;
            var y = 9;
            bool isGreater = x > y;
            Console.WriteLine($"{x} > {y} = {isGreater}.");
            Console.WriteLine("{0} > {1} = {2}", 18, 9, isGreater);
        }
    }
}
