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
            int[] numbers = { 11, 12, 13, 14, 15, 16, 17, 18 };

            var filterArray = numbers.Select(n => new Person() { Age = n });

            List<Person> personList = new List<Person>();

            foreach (var n in numbers)
            {
                var p = new Person()
                {
                    Age = n
                };

                personList.Add(p);
            }
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



