using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.App.Company
{
    public static class Extensions
    {
        public static void Submit<H,T>(this IManager<H> submission, T t) where T : ITender
        {
        }
    }
}
