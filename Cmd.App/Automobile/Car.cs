using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.App.Automobile
{
    public class Car : Vehicle
    {
        public void SetBrand(string brand)
        {
            Brand = brand;
        }

        public string PrintCarBrand()
        {
            return Brand;
        }
    }
}
