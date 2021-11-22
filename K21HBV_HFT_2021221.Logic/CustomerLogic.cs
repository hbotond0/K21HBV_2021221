using K21HBV_HFT_2021221.Models;
using K21HBV_HFT_2021221.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K21HBV_HFT_2021221.Logic
{
    public class CustomerLogic : ICustomerLogic
    {
        ICustomers customerRepo;

        public CustomerLogic(ICustomers customerRepo)
        {
            this.customerRepo = customerRepo;
        }

        public Customers AddNewCustomer(string name, int age)
        {
            throw new NotImplementedException();
        }

        public void ChangeName(int id, string newName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customers> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Customers GetOneCustomer(int id)
        {
            throw new NotImplementedException();
        }
    }
}
