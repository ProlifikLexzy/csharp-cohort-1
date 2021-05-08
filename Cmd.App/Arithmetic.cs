using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.App
{
    //Access Modifier
    //public, private, internal, protected, protected internal
    public class ArithmeticCalculator
    {
        public static void Add()
        {
            Console.WriteLine(1 + 1);
        }
        public static void Add(int first)
        {
            Console.WriteLine(1 + first);
        }
        public static void Add(double first)
        {
            Console.WriteLine(1 + first);
        }

        public static void Add(double first, int second, int third = 9)
        {
            Console.WriteLine(first + second + third);
        }
    }
}
