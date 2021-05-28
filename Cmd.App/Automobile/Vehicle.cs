using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.App.Automobile
{
    public class Vehicle
    {
        public Vehicle()
        {
            Brand = "Unknown";
        }
        protected string Brand { get; set; }
        public void Honk()
        {
            Console.WriteLine("tuuuu tuuuu");
        }
    }
}
