using K21HBV_HFT_2021221.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K21HBV_HFT_2021221.Repository
{
    public class CustomersRepository : Repository<Customers>, ICustomers
    {
        public CustomersRepository(DbContext ctx) :base(ctx)
        {   
        }
        
        public override void AddNew(Customers obj)
        {
            this.Ctx.Set<Customers>().Add(obj);
            this.Ctx.SaveChanges();
        }

        public void ChangeName(int id, string newName)
        {
            var cust = this.ListOne(id);
            if (cust == null)
            {
                throw new InvalidOperationException("Customer was not found!");
            }

            cust.Name = newName;
            this.Ctx.SaveChanges();
        }

        public override void Delete(int id)
        {
            Customers obj = this.ListOne(id);
            this.Ctx.Set<Customers>().Remove(obj);
            this.Ctx.SaveChanges();
        }

        public override Customers ListOne(int id)
        {
            return this.ListAll().SingleOrDefault(x => x.Id == id);
        }
    }
}
