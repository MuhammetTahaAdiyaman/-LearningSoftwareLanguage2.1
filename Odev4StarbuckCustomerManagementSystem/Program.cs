using Odev4StarbucksNeroCustomerManageSystem.Abstract;
using System;
using Odev4StarbucksNeroCustomerManageSystem.Concrete;
using Odev4StarbucksNeroCustomerManageSystem.Entities;
using Odev4StarbucksNeroCustomerManageSystem.Adapters;

namespace Odev4StarbucksNeroCustomerManageSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1999,1,1), FirstName = "Taha", LastName = "Adıyaman", NationalityId = "58345147478" });
            Console.ReadLine();
        }
    }
}
