using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.App.Shapes
{
    public class Rectangle : Shape
    {
        protected int _width;
        protected int _height;
        public Rectangle(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public override double GetArea()
        {
            return _width * _height;
        }
    }
}
