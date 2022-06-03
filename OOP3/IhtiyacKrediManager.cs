using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{//Aynı şekilde TaksitKrediManager ve KonutKrediManager de olduğu gibi inharitance mantığını burada da kullanacağız. Kullanmamızın sebebini diğer ikisinde açıkladım.
 //class IhtiyacKrediManager : KrediManager
 //{
 //}


    /*
     Şimdi en son burayı oluşturduk. Şimdi burada şöyle bir durum söz konusu. Bu hesaplama işleri birbirinin alternatifidir. yani;
    ihtiyaç kredisinin bir faiz oranı vardır belirli dosya masrafları vardır. Konut kredisinin bir faiz oranı vardır belirli dosya masrafları ve diğer masraflar vardır.
    Taşıt kredisinin belirli bir faiz oranı vardır belirli kuralları vardır. Kısacası hepsi de KrediManager.cs de olan Hesapla işini farklı ele alır.
    Yani bu "class KrediManager" tek başına bir anlam ifade etmiyor bu KrediManager class'ı base class olduğu için ebebevn görevi görüyor base görevi görevi görüyor ancak tek başına asla bir anlam ifade etmiyor.
    İşte bu tip alternatif yani imzanın aynı olduğu (imza=metod, void Hesapla() dan bahsediyor KrediManager.cs de olan) ama içerisinin farklı olduğu durumlarda biz base de oluşturduğumuz class'ı yani "class KrediManager {}" ı class olarak değilde interface olarak oluşturururuz. Şimdi KrediManager.cs ye gidelim bu class yapımızı interface halde dönüştürelim ve oradan devam edelim.  
    Not = burada interface den bahsetmişken yapı olarak biraz farklı class yapısından metodlar için süslü parantez açısından demek daha doğru olur;
    class KrediManager
    {
        public void Hesapla()
        {

        }

    }

    ancak interface yapısı şimdi orada da göreceğiz orada da açıklayacağız.

    interface KrediManager
    {
        void Hesapla();
    }

    şimdi KrediManager.cs ye gidelim oradan devam edelim.

     */

    //TasitKrediManager.cs den geliyorum.
    class IhtiyacKrediManager : IKrediManager
    {//interface bize kızmaya devam ediyor çünkü onun mantığına, şablonuna uygun hareket etmiyoruz. şablona uygun hareket etmemiz için interface içinde olan metodları içermek zorunda bunun için sol tarafta veya interface IKrediManager üzerine geldiğimizde bir ampül çıkacak oradan "implement interface" seçeneğine tıklayalım ve aşağıdaki yapıyı oluşturalım. aynı şekilde diğer kredilerimizde de uygulayalım.
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            //Konut ve Taşıt kredisinde yaptığımız uygulamanın aynısını burada da yapalım
            //
            //
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");
        }
    }

















}