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

            var filterNumbers = from num in numbers
                                where num > 15
                                select num;

            foreach (var item in filterNumbers)
            {
                Console.Write($"{item} ");
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] * i;
            }

            Console.WriteLine();

            foreach (var item in filterNumbers)
            {
                Console.Write($"{item} ");
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



