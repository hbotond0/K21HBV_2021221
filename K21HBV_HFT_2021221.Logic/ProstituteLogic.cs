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
            Prostitutes prosti = new Prostitutes()
            { 
                Name = name,
                Category = cat,
                Price = price,
                Age = age,
                STDs = std,
            };
            this.prostiRepo.AddNew(prosti);
            return prosti;
        }

        public void ChangeProstiCategory(int id, string newCategory)
        {
            this.prostiRepo.ChangeCategory(id, newCategory);
        }

        public void ChangeProstiName(int id, string newName)
        {
            this.prostiRepo.ChangeName(id, newName);
        }

        public void ChangeProstiPrice(int id, int newPrice)
        {
            this.prostiRepo.ChangePrice(id, newPrice);
        }

        public void DeleteProsti(int id)
        {
            Prostitutes prosti = this.prostiRepo.ListOne(id);
            if (prosti == null)
            {
                throw new InvalidOperationException("ERROR");
            }
            else
            {
                this.prostiRepo.Delete(id);
            }
        }

        public IEnumerable<Prostitutes> GetAllProsti()
        {
            return this.prostiRepo.ListAll().AsEnumerable();
        }

        public Prostitutes GetOneProsti(int id)
        {
            Prostitutes prosti = this.prostiRepo.ListOne(id);
            if (prosti == null)
            {
                throw new InvalidOperationException("ERROR");
            }
            return prosti;
        }

        public void UpdateProstHasSTD(int id, bool hasSTD)
        {
            this.prostiRepo.UpdateHasSTD(id, hasSTD);
        }
    }
}
