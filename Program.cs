using System;
using TheStore.BL.EntidadesNegocio;
using TheStore.BL.Repository;


namespace TheStore.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var listRepository =
                new CustomerRepositoryList();
            var newCustomer = new SilverCustomer();
            var adressRepository = new AdressRepository();


            newCustomer.Id = 5;
            newCustomer.Name = "Gilberto";
            newCustomer.Email = "gil34@gmail.com";
            newCustomer.Adresses = adressRepository.GetByAdressesById(5);

            listRepository.Save(newCustomer);
            var customers = listRepository.GetAll();


            foreach(var customer in customers)
            {
                System.Console.WriteLine(customer.Name);
            }
        }
    }
}
