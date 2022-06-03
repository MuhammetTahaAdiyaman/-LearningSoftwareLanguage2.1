using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {//OOP2 de biz interihance mantığını görmüştük artık bu interihance mantığı ile birlikte konuşmamız gereken bir diğer konu interface konusudur. Bu derste bunlardan bahsedeceğiz.
     //yine bir bankayı düşünelim bir bankada krediler var ve biz bu krediler ile geri dönüş tutarları belirleyip müşteriye diyoruz ki; eğer sen bu krediyi kullanırsan 2 yılın sonunda bu kadar para ödersin, diğer bir kredi olan çiftçi kredisi kullanırsan bu kadar para ödersin, işte esnaf kredisi kullanrısan bu kadar ödersin vb. Gelin bunu örnekleyelim şimdi class yapılarımızı oluşturalım.  
        static void Main(string[] args)
        {
            //KonutKrediManager.cs den geliyorum
            //şimdi Kredi türlerimizi çağıralım ilk önce instance oluşturacağzı tabii ki daha sonra her kredi'den sonra Hesapla metodumuzu çağıralım bakalım her Kredi türü kendi kuralını mı oluşturmuş(uygulama yapmıştık ya örneğin ihtiyaç kredisi ödeme planı hesaplandı yazdık Hesapla metodu içine onu kastediyorum) yoksa Hesapla metodu tüm kredilerde aynı şeyi mi ekrana basıyor.

            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); // instance.
            //ihtiyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager(); //instance
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager(); //instance
            //konutKrediManager.Hesapla();

            //Hesapla metodunu hepsinde çağırdık çünkü interface uygulamamızı bu Hesapla metodu içine yazdık.
            //şimdi ekrana bastıralım bakalım her kredide aynı şey mi yazacak yoksa farklı şeyler mi yazacak görelim.
            //gördüğümüz üzere Her kredi kendi kuralını oluşturmuş ve kendi kredisine göre ekrana bastır --> interface sayesinde

            //olay aslında şu biz instance oluştururken class ismi ile oluşturuyorduk ya artık class ismi yerine IKrediManager yani interface adını yazdığımızda da aynı sonıucu alacağız aşağıda deneyelim yukarıyı yorum satırına alalım;

            //Console.WriteLine("interfaceli halidir.");

            //IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //ekrana bastıralım bakalım yukarıdaki ile aynı sonuçları mı verecek.
            //görüldüğü üzere yukarıdaki yapı ile Interface kullanılarak oluşturulan instance yapısı aynı şeyi ekrana bastılar.

            //Buradan çıkaracağımız sonuç ise --> interface'lerde o interface'i implemente eden class'ın referans numarasını tutabiliyormuş.
            //burada yani yukarıda yazdığımız kodlar farklı kredilerin hesaplama işlemi şimdi bir bankacılık sistemini düşünelim yine biz bir krediye başvururuz. o başvuruda kredinin hesaplanması işleri yapılır, kayıt işleri yapılır başka başka işler yapılır yani bir tane daha class oluşturalım şimdi depandence injaction öğreneceğiz. bu class ismini krediye başvuru alacağımız başvuru işlemlerinin olduğu "BasvuruManager" ismini verelim. oradan devam edelim.

            //BasvuruManager.cs den geliyorum.
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            //ILoggerService loggerService1 = new DataBaseLoggerService(); //72.satırda anlatmak istediğim bu şekilde de yapılabilir orada da newleyebiliriz. bize lazım olan referans numarası şeklinde olmasıdır.
            ILoggerService loggerService2 = new FileLoggerService();

            //şimdi yukarıdaki kodları ekranda şubedeki görevli arkadaşın ekrandaki seçebileceği krediler olarak düşünelim. Biz bunları ekran haline getirelim sonra işte ekranda açılır kutu var müşteriye soruyor neye başvuruyorsun? müşteride diyor ki ihtiyaç kredisine başvuruyorum işte görevli ihtiyaç kredisini seçiyor, taşıtı'da seçebilir, konutu'da. Unutma bu kodlar şubedeki görevlinin ekranı.
            //şimdi başvuru yapalım. yani BaşvuruManager'ı çağırmamız gerekiyor;

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyacKrediManager); //burada diyorki aslında kod parametresi halinde bana IKrediManager ver diyor ancak burada parantez içine IKrediManager veremeyiz çünkü o bir interface newlenemez. onun yerine referansını tuttuğu ihtiyacKrediManager'ı gönderebiliriz.
            //şimdi ekrandan görevli ihtiyaç kredisi seçmişti ya yukarıda anlattım 50 ve 51.satırda işte adam ekrandan ihtiyaç kredisini seçti bizde BasvuruYap'a ihtiyacKrediManager'ı verdik.
            //**Not = dikkat edin BasvuruManager.cs de BasvuruYap fonksiyonuna parametre olarak IKrediManager'ı yolladık aslında IKrediManager'ı implemente eden IhtıyacKrediManager, TasitKrediManager, KonutKrediManager yani hem taşıt hem konut hem de ihtiyaç kredisini hangisini istiyorsak gönderebiliriz hangisini gönderdiysek de BasvuruYap fonksiyonu içinde yer alan Hesapla fonksiyonu ona ait Hesapla olmuş oluyor bunun sebebi IKrediManager bu üç kredinin referansını tuttuğu için biz parametre olarak girdik.
        
            //Hadi bir simülasyon daha yapalım ve polimorfizm'i gerçek hayattan örnek yaparak bizim için basit bir bilgiye dönüştürelim
            //krediye ihtiyacımız var ve bankaya gittik diyelim. Oradaki memura diyorsunuz ki kredi çekmek istiyorum, memur da ne amaçla kredi çekmek istiyorsun diyor sende araba alacağım diyorsun o da diyor ki ne kadar çekeceksiniz diyor sende diyorsun ki 30 bin tl çekeceğim memurda diyor ki peki hangi krediyi çekmek istersiniz yani senin özelliklerini soruyor memurmusun askermisin kamu çalışamısın vs. sonra memur diyor ki size ihtiyaç kredisi de olur taşıt kredisi de olur diyor hangisini çekmek isterseniz eğer taşıt kredisini çekmek isterseniz bu krediyi ödeyene kadar arabanı ipotek ederiz diyor ihtiyaç kredisinde öyle bir şey yok diyor. sen de müşteri olarak diyorsun ki ihtiyaç kredisi çekersem ne kadar öderim, taşıt kredisi çekersem ne kadar öderim diyorsun bankadaki personel de ekrandan hemen hesaplayalım diyor ve personel ekrandan sana uyduğu için ihtiyaç kredisini seçiyor ve taşıtı seçiyor ve düğmeye basıyor bu sefer hesaplama hem ihtiyaç hem de taşıt kredisi için gerçekleşiyor. şimdi BasvuruManager.cs ye gidelim.                                                                                                                                                         
            //BasvuruManager.cs de 33.satırdan geliyorum.
            //bir tane liste oluşturalım.
            
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            //bankadaki görevli KrediOnBilgilendirme yapması için kredileri yolladı ama List'eden hiç bir şey seçmemiş bomboş bir liste içinde hiç bir şey yok. çalıştırdığımızda ekrana boş gelecek çünkü kredi yok
            //şimdi 64.satıra gidelim ve krediler ekleyelim. şimdi kredileri listeye eklediğimiz için tüm krediler üzerinde işlem yapıldığını çalıştırdığımız gördük.

            //BasvuruYap.cs den geliyorum parametremize loglayıcılarımızı ekledik şimdi burada bir çağıralım diğer BasvuruYapları yorum satırına aldım. şimdi burada BasvuruYap diyecek ki sen krediyi söyle ama ben aynı zamanda bu işi loglayacağım hangi logger'ı kullanayım şimdi onu gösterelim veri tabanına loglayalım.
            basvuruManager.BasvuruYap(konutKrediManager, new DataBaseLoggerService()); //biz yukarıda da newleyebilirdik ama parantez içinde de newleme olanağımız vardır. BasvuruYap konut kredisine göre ve loglamayı veri tabanına göre yap demek bu kod.
        }
    }
}
