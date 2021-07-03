using Cmd.App.Academy;
using Cmd.App.Banking;
using Cmd.App.Collections;
using Cmd.App.Company;
using Cmd.App.Events;
using Cmd.App.Generics;
using Cmd.App.Models;
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
            var num = new int[9];
            var collections = new MyCollections<Employee>() ;
            collections.Add(new Employee());
            
            foreach(var item in collections)
            { 
            }

            var random = new RandomClass();

            random[2] = 800;
            Console.WriteLine(random[2]);

            Console.WriteLine("End of Main");
            Console.Read();
        }
    }


    public class RandomClass<T> where T:
    {
        private int[] numbers = new int[] {9,2, 4 };

        //Indexer
        public T this[int index]
        {
            get
            {
                return numbers[index];
            }
            set
            {
                numbers[index] = value;
            }
        }
    }


}
