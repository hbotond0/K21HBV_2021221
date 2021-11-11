using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K21HBV_HFT_2021221.Repository
{
    public interface IRepository<T> where T : class
    {
        T ListOne(int id);

        IQueryable<T> ListAll();

        void AddNew(T obj);

        void Delete(int id);
    }
}
