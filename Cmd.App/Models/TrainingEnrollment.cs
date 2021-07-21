using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.App.Models
{
    public class TrainingEnrollment : BaseEntity
    {
        public int CourseId { get; set; }
        public int EmployeeId { get; set; }

        public static List<TrainingEnrollment> GetEnrollments()
        {
            return new List<TrainingEnrollment> 
            {
                  new TrainingEnrollment()
                {
                    CourseId = 2,
                    EmployeeId = 115
                },
                new TrainingEnrollment()
                { 
                    CourseId = 1,
                    EmployeeId = 112
                },
                
                new TrainingEnrollment()
                {
                    CourseId = 1,
                    EmployeeId = 113
                },
                new TrainingEnrollment()
                {
                    CourseId = 1,
                    EmployeeId = 114
                },
                new TrainingEnrollment()
                {
                    CourseId = 2,
                    EmployeeId = 112
                },
                new TrainingEnrollment()
                {
                    CourseId = 2,
                    EmployeeId = 114
                },
                new TrainingEnrollment()
                {
                    CourseId = 1,
                    EmployeeId = 115
                },
               
                  new TrainingEnrollment()
                {
                    CourseId = 3,
                    EmployeeId = 115
                },
            };
        }
    }
}
