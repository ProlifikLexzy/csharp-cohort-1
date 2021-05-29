using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.App.Shapes
{
    public class Circle : Shape
    {
        private int _radius;
        public Circle(int width, int height, int radius)
        {
            _radius = radius;
        }

        public override double GetArea()
        {
            var area = Math.PI * (_radius * _radius);
            var round = Math.Round(area, 2);
            return round;

        }


        public int MyProperty { get; set; }

    }
}
