using K21HBV_HFT_2021221.Models;
using K21HBV_HFT_2021221.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K21HBV_HFT_2021221.Logic
{
    public class PimpLogic : IPimpLogic
    {
        IPimps pimpRepo;

        public PimpLogic(IPimps pimpRepo)
        {
            this.pimpRepo = pimpRepo;
        }

        public Pimps AddNewPimp(string name, int rating)
        {
            Pimps pimp = new Pimps()
            {
                Name = name,
                CustomerRating = rating,
            };
            this.pimpRepo.AddNew(pimp);
            return pimp;
        }

        public void ChangeName(int id, string newName)
        {
            this.pimpRepo.ChangeName(id, newName);
        }

        public void DeletePimp(int id)
        {
            Pimps pimp = this.pimpRepo.ListOne(id);
            if (pimp == null)
            {
                throw new InvalidOperationException("ERROR");
            }
            else
            {
                this.pimpRepo.Delete(id);
            }
        }

        public IEnumerable<Pimps> GetAllPimps()
        {
            return this.pimpRepo.ListAll().AsEnumerable();
        }

        public Pimps GetOnePimp(int id)
        {
            Pimps pimp = this.pimpRepo.ListOne(id);
            if (pimp == null)
            {
                throw new InvalidOperationException("ERROR");
            }
            return pimp;
        }

        public void UpdateCustomerRating(int id, int newRating)
        {
            this.pimpRepo.UpdateCustomerRating(id, newRating);
        }
    }
}
