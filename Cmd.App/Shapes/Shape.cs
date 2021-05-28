using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.App.Shapes
{
    public class Shape
    {
        protected int _width;
        protected int _height;

        protected Shape(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public virtual double GetArea()
        {
            return _width * _height;
        }
    }
}
