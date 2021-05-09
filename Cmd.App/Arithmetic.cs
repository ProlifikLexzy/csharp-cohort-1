using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Cmd.App
{
    //Access Modifier
    //public, private, internal, protected, protected internal
    public class ArithmeticCalculator
    {
        public static double Divide(double first, double second)
        {
            return first / second;
        }
        public static void Add()
        {
            WriteLine(1 + 1);
        }
        public static void Add(int first)
        {
            WriteLine(1 + first);
        }
        public static void Add(double first)
        {
            WriteLine(1 + first);
        }
        //method bodied expression
        public static double Add(double first, int second, int third = 9) => (first + second + third);
    }
}
