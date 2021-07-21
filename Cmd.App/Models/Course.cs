using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.App.Models
{
    public class Course : BaseEntity
    {
        public string Title { get; set; }

        public static List<Course> GetCourses()
        {
            return new List<Course>() 
            { 
                new Course()
                { 
                    Id = 1,
                    Title = "Security"
                },
                new Course()
                {
                    Id = 2,
                    Title = "Business Orientation"
                },
                new Course()
                {
                    Id = 3,
                    Title = "Learning Project Management"
                }
            };
        }
    }
}
