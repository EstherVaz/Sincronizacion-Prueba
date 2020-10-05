using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStore.BL.EntidadesNegocio
{ 
    public class OrdenDetail
    {
        //propiedades
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }
        public Product Product { get; set; }


        //metodos
        //public bool Save(OrdenDetail newOrder)
        //{
        //    return true;
        //}
        //public List<OrdenDetail> GetAll ()
        //{
        //    return new List<OrdenDetail>();
        //}
        //public OrdenDetail GetById(int Id)
        //{
        //    return new OrdenDetail();
        //}
        //public bool Delete(int Id)
        //{
        //    return true;
        //}
    }
}
