using K21HBV_HFT_2021221.Models;
using K21HBV_HFT_2021221.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K21HBV_HFT_2021221.Logic
{
    public class ProstituteLogic : IProstituteLogic
    {
        IProstitutes prostiRepo;

        public ProstituteLogic(IProstitutes prostiRepo)
        {
            this.prostiRepo = prostiRepo;
        }

        public Prostitutes AddNewProsti(string name, string cat, int price, int age, bool std)
        {
            throw new NotImplementedException();
        }

        public void ChangeProstiCategory(int id, string newCategory)
        {
            throw new NotImplementedException();
        }

        public void ChangeProstiName(int id, string newName)
        {
            throw new NotImplementedException();
        }

        public void ChangeProstiPrice(int id, int newPrice)
        {
            throw new NotImplementedException();
        }

        public void DeleteProsti(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Prostitutes> GetAllProsti()
        {
            throw new NotImplementedException();
        }

        public Prostitutes GetOneProsti(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProstHasSTD(int id, bool hasSTD)
        {
            throw new NotImplementedException();
        }
    }
}
