using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri(); //class instance
            ////musteri1 = engin demiroğ olsun.
            //musteri1.Adi = "Engin";
            //musteri1.Soyadi = "Demirog";
            //musteri1.Id = 1;
            //musteri1.TcNo = "2222222222222";
            //musteri1.MusteriNo = "123456";
            ////ancak yanlış kullanım yerine geldik.
            //musteri1.SirketAdi = "?" //neden yanlış dedik çünkü bu engin demiroğ ile alakalı bir şey değil biz onu şirket bazlı müşteriler için yazmıştık engin demiroğ bir kişi şirket değil şahıstır. Dolayısı ile şirket adı engin demiroğ kişisi ile alakalı bir şey değil. Bu hatalıdır neden hatalıdır --> zamanla şirket adı olan bireysel müşteriler, zamanla tcno'su olan tüzel müşteriler, zamanla adı soyadı olan tüzel müşteriler ile verilerde karşılaşırsınız çünkü yanlışlıkla girilmiştir.             

            //17.satırın devam şeklinde --> bundan dolayı "GERÇEK MÜŞTERİ(individual) - TÜZEL MÜŞTERİ(Corporate)" olan iki tane nesnem var bu nesnelerin ikiside müşteri bunlar sırf birbirine benziyor diye birbirinin yerine kullanılamazlar. Evet ikisi de müşteri ama bunlar farklı müşteri tipleridir. O yüzden farklı müşteri tipleri bu yüzden birbirinin yerine asla kullanılamazlar. Bu çerçevede bu şekilde hatalı bir tasarım yaparken şunu çok yaparlar --> musteri1.MusteriTipi = 1 ise gerçekte müşteri olsun, musteri1.MusteriTipi = 2 ise tüzel müşteri olsun şeklinde bu da çok hatalıdır. Bu kullanımda şu hataya sebeb olur --> zamanla MusteriTipi gerçek müşteriymiş gibi görünen ama arkada tüzel müşteriymiş gibi tutulan gerçekte tüzel müşteri olan hatalı veri girişinden kaynaklı böyle datalar ile çok karşılaşırız.          
            //yukarıda anlattığımız anlattığımız gerçek müşteri - tüzel müşteri farklı olacak tekniğini yazılım geliştirme prensiplerinden olan SOLID'in L harfidir.     
            //Sırf birbirine benziyor diye orada "soyutlama-interehance" yapma, soyutlamayı yani interehance'yi farklı bir çerçevede ele al diyor. SOLID. 
            //Peki biz bu anlattığımız hatalı kullanımı nasıl ele almalıydık şimdi 2 tane class oluşturalım gerçek müşteri, tüzel müşteri adında.(musteri.cs de oluşturduğumuz özellikleri tüzel ve gerçek müşteri sınıfına paylaştırıyoruz hangisi hangisine aitse)
            //gerçek ve tüzel müşteri class'larımızı oluşturduktan sonra da bir tane operasyon class'ı oluşturacağız yani gelen bir müşteriyi veri tabanına kaydedecek bir operasyon yazmak istediğimizden dolayı bu sınıfı oluşturacağız. şimdi bu sınıfı oluşturalım.(biz GercekMusteri ve TuzelMusteri class'ı içinde operasyonlar olmaz bu class'lar varlık yani bir ürün , bir employee classı gibi entitiy-varlıkdır. operasyon class'larımızı ayrı tutuyorduk bunu geçtiğimiz derslerde görümüştük class 2 ye ayrılır bir özellik tutmak diğeri ise method-operasyonları tutmak için.)  

            //******************************************          
            //inheritance mantığına başlayalım...           
            //Gerçek Müşteri --> Engin Demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345"; //gördüğümüz üzere GercekMusteri class'ı içinde MusteriNo özelliği olmamasına rağmen inharitance mantığı ile (GercekMusteri:Musteri) Musteri class'ı içinde olan MusteriNo özelliğini GercekMusteri class'ı içinde kullanabildik nedeni ise Musteri class'ını ebebevn olarak belirledik yani base class olarak belirledik Musteri Class'ı içinde olan özellikleri (ortak olan özellikleri) hem GercekMusteri hem de TuzelMusteri class'ı içinde kullanabiliyoruz.
            musteri1.Id = 1;//gördüğümüz üzere GercekMusteri class'ı içinde Id özelliği olmamasına rağmen inharitance mantığı ile (GercekMusteri:Musteri) Musteri class'ı içinde olan Id özelliğini GercekMusteri class'ı içinde kullanabildik nedeni ise Musteri class'ını ebebevn olarak belirledik yani base class olarak belirledik Musteri Class'ı içinde olan özellikleri (ortak olan özellikleri) hem GercekMusteri hem de TuzelMusteri class'ı içinde kullanabiliyoruz.
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demirog";
            musteri1.TcNo = "123456789";
            //gördüğümüz üzere anlamsız, karışık olarak görünen yok sadece GercekMusteri'ye ait olan özellikleri getirmiş olduk bu sayede hata yapma olasılığı minimalize oluyor. 

            //şimdi bir tane de Tuzel musteri örneğini oluşturalım.
            //Tuzel Musteri --> Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2; //gördüğümüz üzere TuzelMusteri class'ı içinde Id özelliği olmamasına rağmen inharitance mantığı ile (TuzelMusteri:Musteri) Musteri class'ı içinde olan Id özelliğini TuzelMusteri class'ı içinde kullanabildik nedeni ise Musteri class'ını ebebevn olarak belirledik yani base class olarak belirledik Musteri Class'ı içinde olan özellikleri (ortak olan özellikleri) hem GercekMusteri hem de TuzelMusteri class'ı içinde kullanabiliyoruz.
            musteri2.MusteriNo = "56789"; //gördüğümüz üzere TuzelMusteri class'ı içinde MusteriNo özelliği olmamasına rağmen inharitance mantığı ile (TuzelMusteri:Musteri) Musteri class'ı içinde olan MusteriNo özelliğini TuzelMusteri class'ı içinde kullanabildik nedeni ise Musteri class'ını ebebevn olarak belirledik yani base class olarak belirledik Musteri Class'ı içinde olan özellikleri (ortak olan özellikleri) hem GercekMusteri hem de TuzelMusteri class'ı içinde kullanabiliyoruz.
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            //Aslında biz inheritance mantığını (GercekMusteri : Musteri \\ TuzelMusteri : Musteri) neden yapıyoruz ? --> burada şu anki bilgi ile tamam yukarıda yaptığımız olayları anlarız yani basit böyle temel base class yaparsın ayrı olanları yazarsın, ortak ifadeleri Musteri classında toplarsın sonra Musteri class'ını ebebevn olarak atarsın daha sonra bu Musteri class'ı içinde olan ortak özellikleri hem GercekMusteri hem de TuzelMusteri class'ı içinde kullanabiliriz. ama bu kadar bilgi ile ikna olunacak bir konu değil ancak gerçek projede kendi kendimize diyoruz ki amaan kim uğraşacak şimdi inheritance vs. ben paşa paşa hepsine özellikleri atar yapar geçerim eğer biz bu bilgi ile sınırlı kalırsak sonucumuz düşündüğümüz şekilde olur şimdi aşağıda devam edelim;   
            //yeni birşeyler göreceğiz aşağıda bu sefer Musteri class'ı ile musteri3 ü oluşturalım.

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            //musteri3 ve musteri4 dikkat edersek sol taraf Musteri class'ı ile çağırdık yalnız sağ tarafa baktığımız da hem GercekMusteri hem de TuzelMusteriyi de tutabiliyor. Eğer bir yerde new görürsek her zaman şu şekilde okuyorduk --> new GercekMusteri() = bellekteki referans no'su. aynı şekilde new TuzelMusteri(); de referans no'su. Yani burada --> Musteri class'ı hem GercekMusteri'nin referansını tutabiliyor hem de TuzelMusteri'nin referansını tutabiliyor. Biz bu yüzden MusteriManager.cs de Ekle metoduna parametre olarak Musteri class'ı girdik şimdi aşağıdan devam edelim;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1); //ben bu musteriManager için ekle dediğimizde bakın bu metod benden ne istiyor, benden musteri yazmamı istiyor işte bundan dolayı biz bu Ekle metoduna musteri1, musteri2, musteri3, musteri4 ü de yazabiliriz. musteri1 = GercekMusteri , musteri2 = TuzelMusteri , musteri3 = Musteri-GercekMusteri, musteri4 = Musteri-TuzelMusteri yani farklı class olmalarına rağmen Inheritance mantığı sayesinde bu ekle metoduna hepsini ekleyebiliyoruz. Olay tamamen referans tip, olay base class'ın yani Musteri class'ının yani temel sınıfın onu inherit eden (GercekMusteri - TuzelMusteri)'yi aslında onların referasnını tutabilmesidir.       
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);

            //yukarıdaki ilk örneğimizde amacımız bunların aslında referans tutucu olduğunu göstermeye çalışmaktı. ilerledikçe daha da anlamlı hale gelecektir.

            //şu an bizim MusteriManager.cs de Ekle metoduna parametre olarak müşteriyi gönderiyor olmamız aslında "polimorfizm" dediğimiz çok biçimcilik örneğidir. Yani sen base class (Musteri.cs) üzerinden ilerlediğimiz için base class'da ister gerçek müşteriyi tutabilirsin ister tüzel müşteriyi tutabilirsin.  
            //OOP2 de verilmek istenen mesaj aslında; eğer benim bir base class'ım varsa (ebebevn olan Musteri.cs yi biz base class olarak belirlemiştik --> GercekMusteri : Musteri, TuzelMusteri : Musteri) o base class referans tutucudur.
            //şimdi diğer bir konumuz olan OOP3 den devam edelim.

        }
    }
}
