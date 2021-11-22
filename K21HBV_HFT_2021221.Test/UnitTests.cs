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
        }

        [Test]
        public void TestCreateProsti()
        {
            Mock<IProstitutes> mockedProstiRepo = new Mock<IProstitutes>(MockBehavior.Loose);
            ProstituteLogic prostiLogic = new ProstituteLogic(mockedProstiRepo.Object);
            mockedProstiRepo.Setup(repo => repo.AddNew(It.IsAny<Prostitutes>()));
        }

        [Test]
        public void TestCreatePimp()
        {
            Mock<IPimps> mockedPimpRepo = new Mock<IPimps>(MockBehavior.Loose);
            PimpLogic pimpLogic = new PimpLogic(mockedPimpRepo.Object);
            mockedPimpRepo.Setup(repo => repo.AddNew(It.IsAny<Pimps>()));
        }

        [Test]
        public void TestProstiSTDChange()
        {

        }

        [Test]
        public void TestDeletePimp()
        {

        }

    }
}
