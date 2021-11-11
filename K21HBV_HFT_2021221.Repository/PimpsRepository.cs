using K21HBV_HFT_2021221.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K21HBV_HFT_2021221.Repository
{
    public class PimpsRepository : Repository<Pimps>, IPimps
    {
        public PimpsRepository(DbContext ctx) :base(ctx)
        {
        }

        public override void AddNew(Pimps obj)
        {
            this.Ctx.Set<Pimps>().Add(obj);
            this.Ctx.SaveChanges();
        }

        public void ChangeName(int id, string newName)
        {
            var pimp = this.ListOne(id);
            if (pimp == null)
            {
                throw new InvalidOperationException("Pimp was not found!");
            }

            pimp.Name = newName;
            this.Ctx.SaveChanges();
        }

        public override void Delete(int id)
        {
            Pimps obj = this.ListOne(id);
            this.Ctx.Set<Pimps>().Remove(obj);
            this.Ctx.SaveChanges();
        }

        public override Pimps ListOne(int id)
        {
            return this.ListAll().SingleOrDefault(x => x.Id == id);
        }

        public void UpdateCustomerRating(int id, int newRating)
        {
            var pimp = this.ListOne(id);
            if (pimp == null)
            {
                throw new InvalidOperationException("Pimp was not found!");
            }

            pimp.CustomerRating = newRating;
            this.Ctx.SaveChanges();
        }
    }
}
