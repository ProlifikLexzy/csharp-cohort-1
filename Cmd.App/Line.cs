using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.App
{
    public struct Line
    {
        //tuple
        public static (double, int, string) Draw(double x, int y)
        {
            (double, int, string) t = (x, y, "8");
            return t;
        }
    }
}
