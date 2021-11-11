using K21HBV_HFT_2021221.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K21HBV_HFT_2021221.Repository
{
    public interface IProstitutes : IRepository<Prostitutes>
    {
        void ChangeName(int id, string newName);

        void ChangeCategory(int id, string newCategory);

        void ChangePrice(int id, int newPrice);
        
        void UpdateHasSTD(int id, bool hasSTD);

    }
}
