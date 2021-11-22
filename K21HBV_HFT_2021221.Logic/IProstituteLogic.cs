using K21HBV_HFT_2021221.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K21HBV_HFT_2021221.Logic
{
    public interface IProstituteLogic
    {
        Prostitutes GetOneProsti(int id);

        IEnumerable<Prostitutes> GetAllProsti();

        Prostitutes AddNewProsti(string name, string cat, int price, int age, bool std);

        void UpdateProstHasSTD(int id, bool hasSTD);

        void ChangeProstiPrice(int id, int newPrice);

        void ChangeProstiName(int id, string newName);

        void ChangeProstiCategory(int id, string newCategory);

        void DeleteProsti(int id);
    }
}
