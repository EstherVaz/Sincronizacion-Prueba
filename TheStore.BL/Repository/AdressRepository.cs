using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheStore.BL.EntidadesNegocio;

namespace TheStore.BL.Repository
{
    public class AdressRepository
    {
        
        private List<Adress> Adresses 
            = new List<Adress>();         //Inicializacion de una nueva lsita de direcciones

        internal void InsertAdress(Adress adress)
        {
            throw new NotImplementedException();
        }

        internal static customer GetAdressByCustomerId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Adress> GetByAdressesById(int v)
        {
            throw new NotImplementedException();
        }
    }

    //metodo
    public List<Adress> GetAdressesByCustomerId(int customerid)
    {
        Adresses = new List<Adress>
        {
            new Adress
            {
                Id=1,
                Line1="Av.Principal Vixtha De Madero",
                Line2="Cuarta Manzana",
                City="San Salvador",
                State="Hidalgo",
                Country="Mexico",
                PostalCode="42640",
            },
             new Adress
            {
                Id=2,
                Line1="Col.Rosario",
                Line2="Cuarta Demarcacion",
                City="Rosario",
                State="Hidalgo",
                Country="Mexico",
                PostalCode="465790",
            }
        };
        return Adresses;
    }

    //metodo para insertar
    public bool InsertAdress(Adress newAdress)
    {
        Adresses.Insert(Adresses.count, newAdress);
        return true;
    }
}
    

   