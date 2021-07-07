using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    public class Tester
    {
        public static void Main()
        {
            var people = GetPeople();

            var result = from n in people // initialization
                         let c = Convert.ToInt32("90ssf")
                         where n.Age > 10 && n.Age < 50
                         orderby n.DateOfBirth
                         select n.Age;

        
            foreach (var item in result)
            {
               Console.WriteLine(item);
            }

            var ages = people.Where(c => c.Age > 10 && c.Age < 50)
                .OrderBy(c => c.DateOfBirth)
                .Select(c => c.Age);


            Console.Read();
        }

        //  public static bool Filter(string keyword) => keyword == "John Doe";


        public static void AssignArray(params string[] names)
        {
            string[] n = names;
        }


        public static Person[] GetPeople()
        {
            return new List<Person>()
            {
                new Person(){ FullName = "John Doe", BloodType = "AA" },
                new Person(){ FullName = "Jane Doee" , BloodType = "AS" },
                new Person(){ FullName = "Patric Dovan", BloodType = "AA" },
                new Person(){ FullName = "Ronaldo Christiana" , BloodType = "AA"},
            }.ToArray();
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



