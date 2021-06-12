using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.App.Company
{
    public class VendorSubmission
    {
        public void Submit<T>(T t) where T: ITender
        { 
        }
    }

    public class Quote: ITender { }

    public class Invoice: ITender { }

    public class Receipt: ITender { }

    public interface ITender { }

}
