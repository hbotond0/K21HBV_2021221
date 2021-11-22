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
            Customers cust = new Customers()
            {
                Name = name,
                Age = age,
            };
            this.customerRepo.AddNew(cust);
            return cust;
        }

        public void ChangeName(int id, string newName)
        {
            this.customerRepo.ChangeName(id, newName);
        }

        public void DeleteCustomer(int id)
        {
            Customers cust = this.customerRepo.ListOne(id);
            if (cust == null)
            {
                throw new InvalidOperationException("ERROR");
            }
            else
            {
                this.customerRepo.Delete(id);
            }
        }

        public IEnumerable<Customers> GetAllCustomers()
        {
            return this.customerRepo.ListAll().AsEnumerable();
        }

        public Customers GetOneCustomer(int id)
        {
            Customers cust = this.customerRepo.ListOne(id);
            if (cust == null)
            {
                throw new InvalidOperationException("ERROR");
            }
            return cust;
        }
    }
}
