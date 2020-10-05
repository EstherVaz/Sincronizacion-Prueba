using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStore.BL.EntidadesNegocio
{ 
    public class Product
    {
        //propiedades
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        
    }
}
