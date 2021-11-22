using K21HBV_HFT_2021221.Logic;
using K21HBV_HFT_2021221.Models;
using K21HBV_HFT_2021221.Repository;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K21HBV_HFT_2021221.Test
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void TestCreateCustomer()
        {
            Mock<ICustomers> mockedCustRepo = new Mock<ICustomers>(MockBehavior.Loose);
            CustomerLogic custLogic = new CustomerLogic(mockedCustRepo.Object);
            mockedCustRepo.Setup(repo => repo.AddNew(It.IsAny<Customers>()));
            custLogic.AddNewCustomer("Willy Wonka", 50);
            mockedCustRepo.Verify(repo => repo.AddNew(It.IsAny<Customers>()), Times.Once);
        }

        [Test]
        public void TestCreateProsti()
        {
            Mock<IProstitutes> mockedProstiRepo = new Mock<IProstitutes>(MockBehavior.Loose);
            ProstituteLogic prostiLogic = new ProstituteLogic(mockedProstiRepo.Object);
            mockedProstiRepo.Setup(repo => repo.AddNew(It.IsAny<Prostitutes>()));
            prostiLogic.AddNewProsti("Minnie", "latina", 120, 19, false);
            mockedProstiRepo.Verify(repo => repo.AddNew(It.IsAny<Prostitutes>()), Times.Once);
        }

        [Test]
        public void TestCreatePimp()
        {
            Mock<IPimps> mockedPimpRepo = new Mock<IPimps>(MockBehavior.Loose);
            PimpLogic pimpLogic = new PimpLogic(mockedPimpRepo.Object);
            mockedPimpRepo.Setup(repo => repo.AddNew(It.IsAny<Pimps>()));
            pimpLogic.AddNewPimp("Maffia Boss", 10);
            mockedPimpRepo.Verify(repo => repo.AddNew(It.IsAny<Pimps>()), Times.Once);
        }

        [Test]
        public void TestProstiSTDChange()
        {
            Mock<IProstitutes> mockedProstiRepo = new Mock<IProstitutes>(MockBehavior.Loose);

            List<Prostitutes> testgirls = new List<Prostitutes>()
            {
                new Prostitutes(){ Id = 1, Name = "First Girl", Age = 21, Category = "blonde", Price = 69, STDs = true},
                new Prostitutes(){ Id = 2, Name = "Second Girl", Age = 43, Category = "milf", Price = 200, STDs = false},
            };

            mockedProstiRepo.Setup(repo => repo.ListAll()).Returns(testgirls.AsQueryable());
            mockedProstiRepo.Setup(x => x.ListOne(It.IsAny<int>())).Returns((int i) => testgirls.Where(x => x.Id == i).Single());

            ProstituteLogic prostiLogic = new ProstituteLogic(mockedProstiRepo.Object);

            prostiLogic.UpdateProstHasSTD(1, false);
            mockedProstiRepo.Verify(repo => repo.UpdateHasSTD(1, false), Times.Once);

        }

        [Test]
        public void TestDeletePimp()
        {
            Mock<IPimps> mockedPimpRepo = new Mock<IPimps>(MockBehavior.Loose);


        }

    }
}
