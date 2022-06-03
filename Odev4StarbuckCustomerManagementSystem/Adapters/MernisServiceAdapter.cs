using Odev4StarbucksNeroCustomerManageSystem.Abstract;
using Odev4StarbucksNeroCustomerManageSystem.Entities;
using ServiceReference1;
using System;
using Odev4StarbucksNeroCustomerManageSystem;
using System.Collections;

namespace Odev4StarbucksNeroCustomerManageSystem.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(customer.NationalityId, customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);
        }
    }
}
