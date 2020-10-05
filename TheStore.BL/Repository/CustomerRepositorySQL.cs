using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheStore.BL.Contracts;
using TheStore.BL.EntidadesNegocio;

namespace TheStore.BL.Repository
{
    class CustomerRepositorySQL : ICustomerRepository
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save(customer newCustomer)
        {
            throw new NotImplementedException();
        }
    }
}
