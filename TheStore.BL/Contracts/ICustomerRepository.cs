using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheStore.BL.EntidadesNegocio;

namespace TheStore.BL.Contracts
{
    public interface ICustomerRepository
    {
        public bool Save(customer newCustomer);
        public List<customer> GetAll();
        public customer GetById(int id);
        public bool Delete(int id);
    }
}
