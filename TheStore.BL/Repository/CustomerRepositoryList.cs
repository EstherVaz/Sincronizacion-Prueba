using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheStore.BL.EntidadesNegocio;

namespace TheStore.BL.Repository
{
    public class CustomerRepositoryList
    {
        private List<customer> CustomersData =     //customerData:ALMACENA LA INFO ----Simulacion de una tabla perteneciente a un abse de datos C#
            new List<customer>();
        private AdressRepository adressRepository
            = new AdressRepository();

        



        //DEFINIMOS CONJUNTO DE METODOS (Operaciobnes)
        //metodod GUARDADO DE INFO
        public bool Save(customer newCustomer) //Instancio
        {
            if (newCustomer.Adresses.Count == 0) 
            {
                throw new Exception("Addres Not Found");
            }
            CustomersData.Insert(CustomersData.Count, newCustomer);        //INSERTA registro de nuevo cliente
            foreach(var adress in newCustomer.Adresses)                    //para cada direccion encontrada en newcustomer en su propiedad adresses
            {
                adressRepository.InsertAdress(adress);
            }

        }
        //OBTENER REGISTROS
        public List<customer> GetAll()          //GetAll es el nombre de mi metodo
        {
            foreach( var customer in CustomersData)
            {
                customer.Adresses = adressRepository.GetAdressesByCustomerId(customer.Id);
            }
            return CustomersData;        //devolvera una nueva lista de clientes
        }
        //OBTENER REGISTRO POR Id
        public customer GetById(int id)         //obtiene id de todos los  clientes
        {
            customer Customer = new customer();
            Customer = CustomersData.FirstOrDefault(x => x.Id == id);      //expresion lamnda para indicar cual el es filtro
            return Customer;
            customer Adresses = AdressRepository.GetAdressByCustomerId(id);
        }
        //ELIMINACION
        public bool Delete(int id)
        {
            customer Customer = GetById(id);
            if (customer != null)
            {
                CustomersData.Remove(customer);
                return true;
            }
            return false;
        }
    }
}


