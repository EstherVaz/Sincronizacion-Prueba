using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheStore.BL.EntidadesNegocio;

namespace TheStore.BL.Repository
{
    class OrderRepository
    {
        private List<Orden> Orders = new List<Orden>();         //inicializacion objeto
       
        private ProductRepository productRepository =
            new ProductRepository();
        private List<OrdenDetail> OrderItems =
            new List<OrdenDetail>();




        

        //Metodos...
        public bool Save(Orden newOrden)                //pasa nueva instancia de una orden 
        {
            Orders.Add(new Orden());
            foreach (var orderdetails= newOrden.OrderItems)
            {
                OrderItems.Add(orderdetails);
            }
            return true;

        }
        public List<Orden> GetAll()
        {
            foreach (var Orden in Orders)
            {
                Orden.OrderItems =
                    GetOrderItemsById(Orden.Id);
                return Orders;
            }
        }

        private List<OrdenDetail> GetOrderItemsById(int id)
        {
            throw new NotImplementedException();
        }

        private List<OrdenDetail> GetOrderById(int id)
        {
            var OrderDetail1 = new OrdenDetail
            {
                Id = 1,
                Product = productRepository.GetById(1),
                PurchasePrice = 23.2m,
                Quantity = 2,

            };

            var OrderDetail2 = new OrdenDetail
            {
                Id = 2,
                Product = productRepository.GetById(2),
                PurchasePrice = 105.2m,
                Quantity = 1,

            };
            var OrdenDetailList = new List<OrdenDetail>();
            OrdenDetailList.Add(OrderDetail1);
            OrdenDetailList.Add(OrderDetail2);
            return OrdenDetailList;
        }
        public Orden GetById(int id)
        {
            var Orden= Orders.FirstOrDefault(x => x.Id == id);           //Expresion Lamnda
            Orden.OrderItems =
                GetOrderItemsById(Orden.Id);
            return Orden;
        }
        public bool Delete(int id)
        {
            var Order = Orders.FirstOrDefault(x => x.Id == id);
            if (Order == null)
            {
                return false;
            }
            Orders.Remove(Order);
            return true;

        }
    }
}
