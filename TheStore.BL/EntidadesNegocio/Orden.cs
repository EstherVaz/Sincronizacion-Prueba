using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStore.BL.EntidadesNegocio
{
    public class Orden
    {
        //propiedades
        public int Id { get; set; }
        public DateTimeOffset Date { get; set; }
        public int CustomerId  { get; set; }
        public int ShipAddresId { get; set; }
        public List<OrdenDetail> OrderItems { get; set; }

       
    }
}
