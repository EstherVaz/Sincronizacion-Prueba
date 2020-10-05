using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStore.BL.EntidadesNegocio
{
    public class GoldCustomer: customer
    {
        public List<string> DiscountsCoupons { get; set; }
        public float Discount  { get; set; }
         
    }
}
