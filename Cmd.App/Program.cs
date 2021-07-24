using Cmd.App.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Program
{
    public class Tester
    {
        public static void Main()
        {
            var cSharpKeywords = GetCSharpKeywords();
            var javaKeywords = GetJavaKeywords();

            var employeeList = Employee.GetEmployees();
            var enrollementList = TrainingEnrollment.GetEnrollments();
            var courseList = Course.GetCourses();

            //var setResult = from emp in employeeList
            //                join enroll in enrollementList
            //                on emp.Id equals enroll.EmployeeId
            //                join course in courseList
            //                on enroll.CourseId equals course.Id
            //                select
            //                new
            //                {
            //                    FullName = $"{emp.FirstName} {emp.LastName}",
            //                    CourseTitle = course.Title
            //                };

            var firstJoin = employeeList.Join(enrollementList, 
                emp => emp.Id, enroll => enroll.EmployeeId, (emp, enroll) => new 
                { 
                   FullName = $"{emp.FirstName} {emp.LastName}",
                   enroll.EmployeeId,
                   enroll.CourseId
                });

            //foreach (var item in firstJoin)
            //{
            //    Console.WriteLine("{0} {1}", item.FullName, item.EmployeeId);
            //}

            var setResult = firstJoin.Join(courseList, empEnroll => empEnroll.CourseId,
                course => course.Id, (empEnroll, course) =>
                new
                {
                    empEnroll.FullName,
                    CourseTitle = course.Title
                });
            //Console.WriteLine(setResult);
            foreach (var item in setResult)
            {
                Console.WriteLine("{0}-{1}", item.FullName, item.CourseTitle);
            }

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



