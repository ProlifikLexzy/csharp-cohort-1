using Cmd.App.Banking;
using Cmd.App.Company;
using Cmd.App.Generics;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Program
{
    public delegate X MultiplyDelegate<Z, Y, X>(Z x, Y y);
    public delegate A MultiplyDelegate<A>(A x, A y);
    public delegate void AddDelegate(int x, int y);
    public delegate void SubmissionDelegate(ITender tender);
    public delegate void PersonDelegate(Customer person);

    public class Tester
    {
        public static void Main()
        {
            Calculator();
            Console.WriteLine("End of Main");
        }

        public static void Calculator()
        {

            List<int> arrayList = new List<int>();
            arrayList.Add(9);
            arrayList.Add(12);
            arrayList.Add(14);
            arrayList.Add(10);
           

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            List<string> arrayList2 = new List<string>();
            arrayList2.Add("Error");

            MultiplyDelegate<int, double, double> multiplyDelegate2 = MultiplyDelegate<int, double, double>;
            MultiplyDelegate<int, double, double> multiplyDelegate = MultiplyDelegate;
            AddDelegate delegatedMethod = Add;
            AddDelegate delegatedMethod2 = AddSquare;
            delegatedMethod += AddSquare; //delegate multicasting
            delegatedMethod(2, 2);
            delegatedMethod2(4, 5);

            delegatedMethod -= AddSquare;

            Console.WriteLine("Removed Add Square Method");
            delegatedMethod(2, 2);

            AddNum<int, double>(78, 9);

            //var submission = new VendorSubmission();
            //SubmissionDelegate submissionDelegate = submission.SubmitInvoice;
            //PersonDelegate personDelegate = AssignToCustomer;
        }

        public static C MultiplyDelegate<A, B, C>(A param1, B param2)
        {
            return default;
        }

        public static double MultiplyDelegate(int param1, double param2)
        {
            return param1 * param2;
        }

        public static void Add(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public static void AddSquare(int x, int y)
        {
            var result = x + y;
            Console.WriteLine($"({x} + {y})2 = {result * result}");
        }



        public void AssignToCustomer(Customer customer)
        {

        }


        public static void AddNum<Q, J>(Q one, J two)
        {

        }

    }

    public class Person
    {
    }

    public class Customer : Person { }

}
