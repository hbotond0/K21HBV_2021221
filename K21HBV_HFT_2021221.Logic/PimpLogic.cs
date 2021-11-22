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
            throw new NotImplementedException();
        }

        public void ChangeName(int id, string newName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pimps> GetAllPimps()
        {
            throw new NotImplementedException();
        }

        public Pimps GetOnePimp(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomerRating(int id, int newRating)
        {
            throw new NotImplementedException();
        }
    }
}
