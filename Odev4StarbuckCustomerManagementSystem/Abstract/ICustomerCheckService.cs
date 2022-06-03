using Odev4StarbucksNeroCustomerManageSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev4StarbucksNeroCustomerManageSystem.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer); //şimdi bunu starbucksCustomerManager'a gidip implemente edelim.
    }
}
