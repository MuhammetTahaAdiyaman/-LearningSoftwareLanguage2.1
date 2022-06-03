using Odev4StarbucksNeroCustomerManageSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev4StarbucksNeroCustomerManageSystem.Abstract
{//işte StarbucksCustomerManager.cs de 6.satırda anlatmak istediğimi burada yapacağız bu abstract class'a ICustomerService'i implemente edeceğiz bu abstract class'ıda kahve dükkanlarına inherit edeceğiz dolaylı olarak interface den de yararlancağız referans olarak.
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db" + customer.FirstName);
        }
    }
}
