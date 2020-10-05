using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStore.BL.EntidadesNegocio
{
    public class customer
    {
        //PROPIEDADES
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Adress Adress1 { get; set; }
        public Adress Adress2 { get; set; }
        public List<Adress> Adresses { get; set; }


    }
}
