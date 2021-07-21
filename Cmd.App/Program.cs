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
            var courses = Course.GetCourses();
            var enrollment = TrainingEnrollment.GetEnrollments();
            var employees = Employee.GetEmployees();

            var employeesAndEnroll = employees.Join(enrollment, emp => emp.Id, enroll => enroll.EmployeeId,
                    (emp, enroll) => new
                    {
                        FullName = $"{emp.FirstName} {emp.LastName}",
                        CourseId = enroll.CourseId,

                    });

            var employeesAndEnrollment = employeesAndEnroll.Join(courses, empEnroll => empEnroll.CourseId,
                course => course.Id, (empEnroll, course) => new 
                { 
                    empEnroll.FullName,
                    empEnroll.CourseId,
                    CourseTitle = course.Title
                });

            //var employeesAndEnrollment = from emp in employees
            //                             join enroll in enrollment
            //                             on emp.Id equals enroll.EmployeeId
            //                             join course in courses
            //                             on enroll.CourseId equals course.Id
            //                             select new
            //                             {
            //                                 FullName = $"{emp.FirstName} {emp.LastName}",
            //                                 CourseId = enroll.CourseId,
            //                                 CourseTitle = course.Title
            //                             };

            foreach (var item in employeesAndEnrollment)
            {
                Console.WriteLine($"{item.FullName}\t{item.CourseId}\t{item.CourseTitle}");
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



