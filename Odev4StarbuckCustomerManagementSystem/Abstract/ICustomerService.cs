using Odev4StarbucksNeroCustomerManageSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev4StarbucksNeroCustomerManageSystem.Abstract
{//iki firmada müşterilerini veri tabanına kaydetmek istiyormuş o zaman iki firmanında save metodu olacak bundan dolayı aşağıya save medotunun imzasını oluşturalım.
    public interface ICustomerService
    {
        void Save(Customer customer); //parametre olarak Customer geçelim
    }
}
