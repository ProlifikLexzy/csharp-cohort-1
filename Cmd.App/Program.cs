using Cmd.App.Academy;
using Cmd.App.Banking;
using Cmd.App.Company;
using Cmd.App.Events;
using Cmd.App.Generics;
using Cmd.App.Shapes;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;

namespace Program
{

    public class Tester
    {
        public static void Main()
        {

            var v = new Value() { Val = 6 };
            Arithemetic.Add(v, 9);
            Console.WriteLine("End of Main");
            Console.Read();
        }
    }

    /// <summary>
    /// A class for carry out arithmentic operation
    /// </summary>
    public class Arithemetic
    {
        /// <summary>
        /// A method to add 2 numbers
        /// </summary>
        /// <param name="first">First parameter of type <see cref="Value"/></param>
        /// <param name="second">Second Parameter</param>
        /// <returns>Returns a type of <see cref="Value"/></returns>
        public static Result Add(Value first, int second)
        {
            return first + second;
        }
    }

    /// <summary>
    /// Result a value
    /// </summary>
    public class Value
    {
        public int Val { get; set; }

        public static Result operator +(Value first, int second)
        {
            return new Result() { Val = first.Val + second };
        }
        public static Result operator -(Value first, int second)
        {
            return new Result() { Val = first.Val + second };
        }
    }

    public class Result
    {
        public int Val { get; set; }
    }

}
