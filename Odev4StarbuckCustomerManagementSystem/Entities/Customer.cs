using Odev4StarbucksNeroCustomerManageSystem.Abstract;
using System;

namespace Odev4StarbucksNeroCustomerManageSystem.Entities
{//somut sınıflar buradaki gibi eğer çıplak kalıyorsa yani herhangi bir inheritance veya implemantasyon almıyorsa ileride nesnellik zaafiyeti yaşayacağız sırf bu tip kurallar için veri tabanı nesnesi olan IEntity interfaci oluşturalım abstract klasörü içinde ve bu nesneye implemente edelim

    public class Customer : IEntity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string NationalityId { get; set; } //tc
    }
}
