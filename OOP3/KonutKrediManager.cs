using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{//şimdi bu class'ımızda bir inheritance yapısı şeklinde oluşturalım çünkü bu class'ımızın içinde de KrediManager.cs de olduğu gibi hesapla olsun istiyorum. O zaman ayrı ayrı yazmak yerine KrediManager.cs de bir tane Hesapla metodumuz varken burada onu interihance mantığı ile kullanalım.
    class KonutKrediManager : IKrediManager //inharitance mantığıdır. OOP2 de gördük şu anlama çıkıyor KonutKrediManager class'ı bir KrediManager class'ıdır. yani KrediManager da olan methodları burada da kullanabiliriz. Şimdi bir kaç tane daha kredi çeşiti olarak class oluşturalım bunun sonucunda mükemmel "polimorfizm" öğreneceğiz.
    {//interface bize kızmaya devam ediyor çünkü onun mantığına, şablonuna uygun hareket etmiyoruz. şablona uygun hareket etmemiz için interface içinde olan metodları içermek zorunda bunun için sol tarafta veya interface IKrediManager üzerine geldiğimizde bir ampül çıkacak oradan "implement interface" seçeneğine tıklayalım ve aşağıdaki yapıyı oluşturalım. aynı şekilde diğer kredilerimizde de uygulayalım.
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            //
            //
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı");
        }
        //şimdi Hesapla metodu içinde bir uygulama şeklinde yapalım sanki kodlar yazılmış en son bilgi mesajı içeren bir metin yazalım. Aynı hareketi diğer Ihtiyac kredisi ve Tasit kredisi içinde yapalim
        /*
         Not = şu ana kadar anlaşılmayacak hiç bir şey yok. KrediManager bir interface bu interface kuralları içerir (kurallar = şablon = metodlar = void Hesapla(), void BiseyYap()) ve onu implemente eden (interface'lere implementasyon deniyor) class'lar (IhtiyacKrediManager.cs, TasitKrediManager.cs, KonutKrediManager.cs) o kuralları yani metodları (Hesapla, BiseyYap) kendine göre doldurmak durumunda.    
         Yani mantiken de böyle değil mi ? Mantiken de ihtiyaç kredisinin farklı kodları var, taşıt kredisinin farklı kodları var, konut kredisinin farklı kodları var. 
         Bunu kötü programlayan bir programcının yapacağı hareket şu şekilde olur; 
           - KrediManager yapısını class olarak alır ve methodları parametre şeklinde oluşturur ve method içinde if else yapısı ise if kredi türü Taşıt kredisi ise şunu yap, diğer kredi ise bunu yap interface de yaptığımız uygulamayı burada yapalım aşağıda ne kadar çorba olacağını gözlerimizle görelim.
                class KrediManager
                {
                    void public Hesapla(int krediTuru)
                    {   
                          if(krediTuru == IhtiyacKrediManager)
                          {
                            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı")  
                          } 
                          else if ( KrediTuru == TasitKrediManager)
                          {
                            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı")  
                          } 
                          else if ( KrediTuru == KonutKrediManager)
                          {
                            Console.WriteLine("Konut kredisi ödeme planı hesaplandı")  
                          }   
                    }    
                        
                }
           --> gördüğümüz gibi çorba şeklinde oldu ve burada 3 tane kredi şeklinde böyle bir bankada en az 350 kredi türü olduğunu varsayarsak if else mantığı ile 100 kredi yapsıını oluşturup daha sonra her kredi kurallarını bu if else ile oluşturduğun yapının içine atadığımızı düşünürsek ortalık çorba olur bundan dolayı iyi bir programcı interface yapısını kullanır bu tür durumlarda.       
           --> Not2 = genellikle interface'leri "operasyonel metodlar" da kullanırız interface leri ? genellikle evet. ********
           --> tam olarak neden soyutlama yapıyoruz birazdan geleceğiz.
           --> şimdi program.cs ye gidelim ve oradan devam edelim.
         */


    }
}
