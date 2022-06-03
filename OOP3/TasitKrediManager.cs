using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{//Aynı şekilde burada da KonutKrediManager.cs de olduğu gibi inheritance mantığını yapalım. TasitKrediManager:KrediManager demek TasitKrediManager class'ı bir KrediManager class'ıdır. yani base class olarak belirlediğimiz KrediManager.cs hem KonutKrediManager class'ın hem de TasitKrediManager class'ın hem de diğer oluşturacağımız kredi classlarının referans numarasını tutacaktır ve bu sayede KrediManager.cs de olan bir method veya operasyonu bu şekilde bu class içinde olmasa bile kullanabileceğiz OOP2 de bunlardan bahsetmiştik.
    class TasitKrediManager : IKrediManager //burada inherit ettiğimiz için artık TasitKrediManager, KrediManager da olan Ekle methoduna bu sayede bu class içinde olmasa bile sahip olmuş oldu. Şimdi 3.kredimiz olan IhtiyacKrediManager class'ımızı oluşturalım.
    {//interface bize kızmaya devam ediyor çünkü onun mantığına, şablonuna uygun hareket etmiyoruz. şablona uygun hareket etmemiz için interface içinde olan metodları içermek zorunda bunun için sol tarafta veya interface IKrediManager üzerine geldiğimizde bir ampül çıkacak oradan "implement interface" seçeneğine tıklayalım ve aşağıdaki yapıyı oluşturalım. aynı şekilde diğer kredilerimizde de uygulayalım.
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            //Konut kredisinde yaptığımız aynı şeyi burada da yapacağız.
            //
            //
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı");
        }
    }
}
