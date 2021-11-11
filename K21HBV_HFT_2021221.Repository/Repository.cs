using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K21HBV_HFT_2021221.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        DbContext ctx;

        public Repository(DbContext ctx)
        {
            this.ctx = ctx;
        }

        protected DbContext Ctx { get => this.ctx; set => this.ctx = value; }

        public abstract void AddNew(T obj);

        public abstract void Delete(int id);

        public IQueryable<T> ListAll()
        {
            return this.ctx.Set<T>();
        }

        public abstract T ListOne(int id);
    }
}
