using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.App.Company
{
    public class VendorSubmission
    {
        public void SubmitInvoice(ITender invoice)
        {

        }
    }

    public class Quote: ITender { }

    public class Invoice: ITender { }

    public class Receipt: ITender { }

    public interface ITender { }

}
