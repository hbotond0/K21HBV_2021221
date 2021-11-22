using K21HBV_HFT_2021221.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K21HBV_HFT_2021221.Logic
{
    public interface IPimpLogic
    {
        Pimps GetOnePimp(int id);

        IEnumerable<Pimps> GetAllPimps();

        Pimps AddNewPimp(string name, int rating);

        void ChangeName(int id, string newName);

        void UpdateCustomerRating(int id, int newRating);

        void DeletePimp(int id);
    }
}
