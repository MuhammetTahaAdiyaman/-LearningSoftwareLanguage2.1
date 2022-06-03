using Odev4StarbucksNeroCustomerManageSystem.Abstract;
using Odev4StarbucksNeroCustomerManageSystem.Entities;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev4StarbucksNeroCustomerManageSystem.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        
        public bool CheckIfRealPerson(Customer customer)
        {
            //mernisi buraya bağlayacağız ancak mernise bağımlı kalmamak için sistemimizin çalışma koşulu bir adaptöre ihtiyacımız var hemen bir adaptör class ı oluşturalım.
            return true;
        }
    }
}
