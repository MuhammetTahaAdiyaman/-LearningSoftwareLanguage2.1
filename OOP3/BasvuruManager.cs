using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{//burada herhangi bir krediye başvuru alacağız şimdi aşağıda gösterelim
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)//20.satırdan geldim. şimdi burada şu mantığı oturtacağız her başvuru kredisine göre hesaplamak istiyoruz ya burada şu mantığı yapacağız bir parametre alsam ve desem ki "bu başvuruyu hangi krediye göre yapmam gerektiğini bana söyle" desem. o zaman elimde herkesin referansını tutabilen bir interface vardı --> IKrediManager işte burada parametre olarak girelim ki, hesaplama krediye göre şekillensin. Parametre olarak bu tüm kredilerin(taşıt, ihtiyaç, konut) referansını tutan IKrediManager'ı parametre olarak girdiğimizde ister konut, ister ihtiyaç, istersem de taşıt kredisini rahatlıkla yollayabiliriz. eğer bunu parametre olarak girmeseydik 16.ve17.satırda yaşadığımız tüm kodları bir kredi üzerinden hesaplamak zorunda kalacaktık zaten bu da yanlış demiştik. 
        {//başvuru yapması için ne yaparız çeşitli bilgiler alırız aşağıda gösterelim bilgileri simüle ediyoruz kod gibi düşün.

            //Başvuran bilgilerini değerlendirme(böyle bir sürü kod yazarız)
            //
            //
            //şimdi krediyi hesaplayalım yani bu BasvuruYap algoritmasının içinde bir de krediyi hesaplayalım
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            //biz 16 ve 17.satırdaki gibi krediyi hesaplamak istersek bu kod çalışır ancak şöyle bir durum olur tüm başvurular konut kredisi üzerinden hesaplanır hani demiştik ya konut kredisi farklı hesaplanır, taşıt kredisi farklı hesaplanır, ihtiyaç kredisi farklı hesaplanır işte biz bu kodu yazarsak tüm başvurular konut kredisi üzerinden hesaplanır.
            //buraya dikkat bu bilgi programcılık hayatımızın kırılma noktası olabilir bütün design pattern ifadelerini anlayabileceğimiz bir noktaya geldik. Bütün design pattern'lar bunun üzerine kuruludur. Bu mantık üzerine kurulur yani; konutKrediManager dersek ben ne yaptım tüm başvuruları konutkredisi'ne bağımlı hale getirdim.
            //yukarıda yani 16.17. satırda yazdığımız kod doğru bir şey değil benim amacım her başvuru kendi içinde hesaplanmasını istiyorum yani Konut kredisi konut kredisine göre, ihtiyaç kredisi ihtiyaç kredisine göre, taşıt kredisi taşıt kredisine göre hesaplanması gerekir. bunun için parametre üzerinden gideceğiz 9.satırdaki koda gidelim. BaşvuruYap parametre olarak şu mantığı yapacağız bir parametre alsam ve desem ki "bu başvuruyu hangi krediye göre yapmam gerektiğini bana söyle" desem.

            //şimdi 9.satırdan geliyorum şu anda başvuruyu kredi bağımsız hale getirdim bu parametreyi şu şekilde çağıralım.
            krediManager.Hesapla(); //--> artık taşıt kredisini gönderirsek, IKrediManager taşıt kredisinin referansı ya artık bellekteki bu kod taşıt kredisine ait olan hesapla şeklinde çalışır veya başka bir örnek ben konut kredisini gönderdin, IKrediManager konut kredisinin referansını tuttuğu için bu kod bellekteki Konut kredisine ait Hesapla şeklinde çalışır, ihtiyaç kredisi de bu şekilde. Biz BasvuruYap fonksiyonuna parametre olarak bu üç kredinin referansını tutan IKrediManager'ı aldığımız için artık burada hangisine göre hareket etmek istiyorsak referansını tuttuğu için ona göre hareket edecektir kısaca bunu anlatıyor.
            //şimdi program.cs ye gidelim oradan devam edelim.
            
            //buraya FileLoggerService den geldim parametre olarak ILoggerService ekledim çünkü burada loglama metodunuda kullanmak istediğim için neden ILoggerService kullandık çünkü ILoggerService hem File hem de DataBase servislerin referanslarını tutuyor. implemente etmiştik ya
            loggerService.Log();//hangi loglayıcı seçilmişse sistemde onu logla.
            //aslında biz burada metod injection yapıyoruz. yani bu krediManager.Hesapla() metodunun kullanacağı krediManager'ın(parametre) ne olacağını hangi kredi türü olacağını ve hangi loglayıcı olacağını enjeckte ediyoruz bunun bir de constructor enjection var onu ödevde göstereceğiz. 
            //şimdi program.cs den bu yaptığımız olayları bir çalıştıralım.
            //eğer birden fazla logger ile çalışmak istersek aşağıdaki gibi List<ILoggerService> loggerService şeklinde parametre gireriz. şöyle düşünelim hepsiburadadan alışveriş yaptın hem kendi veritabanına kaydediyor hem de sana mail geliyor.
        }

        //program.cs de 59.satırdan geldim
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {//şimdi bankadaki memur kaç tane kredi üzerinde işlem yapabilir belirsiz. yani o an taşıt da olabilir ihtiyaç da olabilir esnaf, memur da olabilir yani o anki ekrandan isterse 3 tane aynı anda isterse 2 tane isterse 1 tane kredi seçebilir yani kaç tane seçeceği belli değil o zaman aynı veri türünde belli sayıda o sayıda belirsiz ise bir veri grubu oluşturmak istersek ne kullanıyorduk ? List mantığını kullanıyorduk. o zaman parametre olarak List yöntemini kullanacağız. parametreye diyorum ki "bana bir liste ver krediler listesi ve veri türü IKrediManager olsun çünkü IKrediManager üç kredinin de referansını tuttuğu için"                                                               
         //yukarıda BasvuruYap da tek bir kredi üzerinden işlem yapabiliyorduk yani ihtiyaç ise ihtiyaç, konut ise konut, taşıt ise taşıt ancak burada List yöntemi ile birden fazla kredi üzerinde hesaplama yapabilme imkanına sahip oldum parametre olarak IKrediManager girmemizin nedeni ise IKrediManager üç kredinin de referansını tuttuğu için. 
         //şimdi program.cs ye gidelim

            //yukarıda BasvuruYap içinde hesapla ile hallediyorduk ama burada bir Liste olduğuna göre bunların yani Listedeki her bir krediyi tek tek dolaşmak gerekiyor bunun için foreach kullanalım. 
            foreach (var kredi in krediler)
            {
                kredi.Hesapla(); //Listede bulunan her bir kredinin hesabını yap
            }
        }



    }
}
