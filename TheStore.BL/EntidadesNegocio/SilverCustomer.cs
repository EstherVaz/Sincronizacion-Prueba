using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStore.BL.EntidadesNegocio
{
    public class SilverCustomer: customer
    {
        public int RemainingPurchases { get; set; }
        //CONSTRUCTOR
        public SilverCustomer()
        {
            Email=" ";
        }
    }
}
