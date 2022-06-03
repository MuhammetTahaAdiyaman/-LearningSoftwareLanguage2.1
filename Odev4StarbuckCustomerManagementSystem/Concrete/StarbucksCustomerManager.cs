using Odev4StarbucksNeroCustomerManageSystem.Abstract;
using Odev4StarbucksNeroCustomerManageSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev4StarbucksNeroCustomerManageSystem.Concrete
{//normalde hem starbucks'ı hem de nero'yu ICustomerService ile implemente edebiliriz (interface) amacımız direkt referansa ulaşmak ancak senaryoda güzel bir ayrıntıya yer verilmiş o ayrıntı ise şu şekilde; hem starbucks'ı hem de nero'yu aynı veritabanına kaydediyoruz yani ikisininde veritabanı operasyonu kesinlikle aynı ikiside aynı tabloya yazılacak o zaman biz interface implementasyonu yerine abstract class oluşturup bu class'ı inherit edebiliriz aryıca abstract class'a ICustomerService'ı implemente edersek dolaylı olarak ICustomerService referansından da yararlanacağız.
 //kod implementasyonunda abstract class oluştur --> BaseCustomerManager adında
    public class StarbucksCustomerManager: BaseCustomerManager  //6.satırda anlattığım olayı gerçeleştiriyorum
    {//starbucks ile ilgili bir durum var o durumda şu; starbuck müşterilerini kaydederken gerçek müşteri istediğinden dolayı mernis sorgulaması istiyor işte burada onu gerçekleştireceğiz

        private readonly ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
       
        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {//doğru bir müşteri olmasını arzu ediyoruz
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }

        //private void CheckIfRealPerson(Customer customer)
        //{
        //    //mernise direkt buradan bağlanabiliriz ancak yarın bir gün nero kahvecisi de ben de mernis yoklaması almak istiyorum derse ne yapacağız ? bundan dolayı böyle bir senaryoda devreye interfacelerin ability dediğimiz kural giriyor o yüzden abstract dosyası içinde interface yazacağız ismi de ICustomerCheckService adında dosya açalım ve onun referansını kullancağız.
        //    //işte burada yazdığımız metodu direkt olarak ICustomerCheckService interfacei içine yazmalıyız. Hani yarın neroda isterse diye oraya da yazalım dedik.
        //}
    }
}
