using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.App.Models
{
    public class Employee : BaseEntity
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public List<int> Scores { get; set; }
        public int Score { get; set; }

        public static List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee
                {
                    FirstName="Svetlana",
                    LastName="Omelchenko",
                    Id=111,
                    Scores= new List<int> {97, 92, 81, 60}
                },
                new Employee {FirstName="Claire", LastName="O'Donnell", Id=112, Scores= new List<int> {75, 84, 91, 39}},
                new Employee {FirstName="Sven", LastName="Mortensen", Id=113, Scores= new List<int> {88, 94, 65, 91}},
                new Employee {FirstName="Cesar", LastName="Garcia", Id=114, Scores= new List<int> {97, 89, 85, 82}},
                new Employee {FirstName="Debra", LastName="Garcia", Id =115, Scores= new List<int> {35, 72, 91, 70}},
            };
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
