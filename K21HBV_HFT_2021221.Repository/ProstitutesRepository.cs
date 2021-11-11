using K21HBV_HFT_2021221.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K21HBV_HFT_2021221.Repository
{
    public class ProstitutesRepository : Repository<Prostitutes>, IProstitutes
    {
        public ProstitutesRepository(DbContext ctx) : base(ctx)
        {
        }

        public override void AddNew(Prostitutes obj)
        {
            this.Ctx.Set<Prostitutes>().Add(obj);
            this.Ctx.SaveChanges();
        }

        public void ChangeCategory(int id, string newCategory)
        {
            var girl = this.ListOne(id);
            if (girl == null)
            {
                throw new InvalidOperationException("Girl was not found!");
            }

            girl.Category = newCategory;
            this.Ctx.SaveChanges();
        }

        public void ChangeName(int id, string newName)
        {
            var girl = this.ListOne(id);
            if (girl == null)
            {
                throw new InvalidOperationException("Girl was not found!");
            }

            girl.Name = newName;
            this.Ctx.SaveChanges();
        }

        public void ChangePrice(int id, int newPrice)
        {
            var girl = this.ListOne(id);
            if (girl == null)
            {
                throw new InvalidOperationException("Girl was not found!");
            }

            girl.Price = newPrice;
            this.Ctx.SaveChanges();
        }

        public override void Delete(int id)
        {
            Prostitutes obj = this.ListOne(id);
            this.Ctx.Set<Prostitutes>().Remove(obj);
            this.Ctx.SaveChanges();
        }

        public override Prostitutes ListOne(int id)
        {
            return this.ListAll().SingleOrDefault(x => x.Id == id);
        }

        public void UpdateHasSTD(int id, bool hasSTD)
        {
            var girl = this.ListOne(id);
            if (girl == null)
            {
                throw new InvalidOperationException("Girl was not found!");
            }

            girl.STDs = hasSTD;
            this.Ctx.SaveChanges();
        }
    }
}
