using System;
using System.Collections.Generic;
using System.Threading;

namespace Program
{
    public class Tester
    {
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(() =>
            {
                int numberOfSeconds = 0;
                while (numberOfSeconds < 10)
                {
                    Console.WriteLine(++numberOfSeconds);
                    Thread.Sleep(1000);
                }
            });

            Thread t2 = new Thread(() =>
            {
                int numberOfSeconds = 50;
                while (numberOfSeconds < 70)
                {
                    Console.WriteLine(++numberOfSeconds);
                    Thread.Sleep(1000);
                }
            });

            t1.Start();
            t2.Start();
            Console.WriteLine("Thread Started.");

            //Console.ReadLine();
        }

        public static List<string> GetCSharpKeywords()
        {
            return new List<string>
            {
                "abstract","as", "base","bool","break",
                "byte","case"," catch","  char","checked",
                "class","const","continue", "decimal","default",
                "delegate", "do","double"," else","enum",
                "event","explicit", "extern","false","finally",
                "fixed", "float","for"," foreach","goto",
                "if","implicit", "in", "int","interface",
                "internal", "is","lock","long","namespace",
                "new","null","object","operator","out",
                "override", "params", "private", "protected", "public",
                "readonly ref","return", "sbyte", "sealed",
                "short","sizeof", "stackalloc",   "static" ,"string",
                "struct"," switch", "this","throw","true",
                "try"," typeof", "uint","ulong","unchecked",
                "unsafe", "ushort", "using"," virtual", "void",
                "volatile" ,"while"
            };
        }

        public static List<string> GetJavaKeywords()
        {
            return new List<string>
            {
                "abstract", "do", "if", "package", "synchronized",
                "boolean",  "double", "implements", "private", "this",
                "break", "else",  "import", "protected",  "throw",
                "byte", "extends", "instanceof",  " public", "throws",
                "case", "false", "int", " return", "transient",
                "catch", "final",   "interface", "short", "true",
                "char", "finally",    "long", "static",  "try",
                "class ",  " float", "native",    "strictfp",    " void",
                "const",  "for",  " new"
            };
        }
    }

    public class Person
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string BloodType { get; set; }
        public int Age { get; set; } = 100;
    }

}



