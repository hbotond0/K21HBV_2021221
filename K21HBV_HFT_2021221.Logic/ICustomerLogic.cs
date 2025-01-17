﻿using K21HBV_HFT_2021221.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K21HBV_HFT_2021221.Logic
{
    public interface ICustomerLogic
    {
        Customers GetOneCustomer(int id);

        IEnumerable<Customers> GetAllCustomers();

        Customers AddNewCustomer(string name, int age);

        void ChangeName(int id, string newName);

        void DeleteCustomer(int id);
    }
}
