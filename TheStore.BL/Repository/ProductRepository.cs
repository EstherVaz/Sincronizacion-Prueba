using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheStore.BL.EntidadesNegocio;

namespace TheStore.BL.Repository
{
    class ProductRepository
    {
        private List<Product> ProductsData =
            new List<Product>();
        
        
        //Metodos
        //metodo Save
        public bool Save(Product newProduct)            //Parametro y nombre de parametro "newProduct"
        {
            ProductsData.Insert(ProductsData.Count, newProduct);
            return true;
        }
        //nueva lista de productos
        public List<Product> GetAll()                   //Devuelve una lista de diferentes productos
        {
            return ProductsData;                 //Nueva Lista de productos
        }
        public Product GetById(int id)                  //Parametro id de registro que se quiere devolver
        {
            return ProductsData.FirstOrDefault(x => x.Id== id);                       //Nueva Instancia de un producto
        }
        public bool Delete(int id)                      //Eliminar id de registro 
        {
            var product = GetById(id);
            if (product != null)

            {
                ProductsData.Remove(product);
                return true;
            }
            return false;
        }
    }
}
