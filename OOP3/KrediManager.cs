using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{//bu class yapımız adından da belli olduğu gibi Manager yani operasyonlar-methodlar'ı tutacağımız bir class olacak.
    /*class KrediManager
    {
        public void Hesapla()
        {
            //eğer biz hangi krediye nasıl hesaplanması gerektiğini yani esnaf kredisi ise şöyle hesapla, çiftçi kredisi ise şöyle hesapla dersek ve bir bankada 100 den fazla kredi olduğunu düşünürsek aşağıdaki gibi if else mantığı ile yapmaya çalışırsak burası çorbaya döner bundan dolayı KonutKrediManager.cs yi oluşturalım. 
            //if(Kredi == )
            //{

            //}


        }
    }
    */ //biz class yapısını yukarıdaki gibi öğrenmiştik şimdi buraya IhtıyacKrediManager.cs den geliyoruz orada bahsettik neden interface kullanmamız gerektiğini aşağıda yukarıdaki class'ımızı interface 'e dönüştürelim
    //interface aslında benim şablonum görevini görüyor normalde hepsi için ayrı ayrı class'lar açılmalıdır.
   //NOT=** İNTERFACE'LERİ biz birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.** Yaptığımız örnekte kredi türlerinin hepsinde hesaplama fonksiyonu vardır geri ödeme planı vardır peki bir bankada 300 tane kredi olduğunu varsayalım hepsinde geri ödeme planı yani hesapla fonksiyonu olmak zorunda değil mi ortak olarak ama kodları farklıdır faiz oranından tutun, dosya masrafı farklı kurallar vb. kredinin tülerine göre bu hesaplama işleri değişkenlik gösterir.
    interface IKrediManager//interface yapısıda class gibi olur ancak metod yazımı biraz farklı aşağıda gösterelim ve açıklayalım
    {
        void Hesapla();

        void BiseyYap();

    }
    //bir interface şunu anlatır der ki ; eğer ki birisi bu interface'ini kullanırsa o arkadaşım interface'in içerdiği metodu içermek zorunda. Şimdi yukarıdaki koda göre anlamlandıralım eğer ki birisi KrediManager interface'ini kullanırsa kullandığı yerde KrediManager interface yapısı içinde olan Hesapla metodunu içermek zorundadır. içersiinde birden fazla metod da olabilir yukarıya yeni bir metod ekleyelim bisey yap adında.
    //eğer ki bir class (sınıf) yapısı (KonuKrediManager.cs, TasitKrediManager.cs, IhtiyacKrediManager.cs gibi ) bir interface'i "class IhtiyacKrediManager:KrediManager" gibi yani inheritance şeklinde kullanıyorsa yani bu interface diyorki class yapısına sen benim KrediManager kurallarıma uymak zorundasın o yüzden her kredi mutlaka bu KrediManager interface içinde olan methodları içermek zorunda. Diğer oluştruduğumuz IhtiyacKrediManager.cs, TasitKrediManager.cs, KonutKrediManager.cs ye gidip bakalım interface orada bize kızıyor işte kızma sebebi bu yani KrediManager interface'i içinde olan methodları içermediklerinden dolayı.
    //diğer bir önemli kısım ise okunurluğu arttırmak için biz interface'leri "I" harfi ile başlatırız. şimdi yukarıdaki interface'imizin başına I harfini ekleyelim. ki bunun inteface olduğunu anlarız.
    //void Hesapla(), void BiseyYap() methodları bankadaki her kredide olması gereken methodlardır. bunu zorunlu yapıyoruz bu yüzden yeni bir kredi oluşturacağımız zaman mutlaka bu interface'den implemente olduğu için bu iki metodu (Hesapla ve BiseyYap) içermek zorunda. İnterface = şablon, arayüz demek, asıl gerçek hayat kullanımına birazdan geleceğiz şu anlık için interface = arayüz, şablon demek olduğu için yani şu şablona (interface'in süslü parantez içinde olan metodlara) uymak zorundasın demek. şimdi KonutKrediManager.cs ye gidelim ve interface yapısına uygun şekilde düzenleyelim. şablona uygun hareket edelim yoksa interface o class içinde bize kızmaya devam edecek.



   //NOT=** İNTERFACE'LERİ biz birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.** Yaptığımız örnekte kredi türlerinin hepsinde hesaplama fonksiyonu vardır geri ödeme planı vardır peki bir bankada 300 tane kredi olduğunu varsayalım hepsinde geri ödeme planı yani hesapla fonksiyonu olmak zorunda değil mi ortak olarak ama kodları farklıdır faiz oranından tutun, dosya masrafı farklı kurallar vb. kredinin tülerine göre bu hesaplama işleri değişkenlik gösterir.
   /*şimdi gerçek hayattan bir örnek verelim;
    örneğin biz projemizde loglama yapmak istiyorsunuz;
   loglama = kim ne zaman hangi operasyonu çağırdıdır yani bir nevi sistemde olan hareketleri döktüğümüz bir dökümdür
   hadi gelelim bunu bir enjekte edelim.
   loglama dediğimiz zaman loglama'yı farklı yöntemler ile uygulayabiliriz.
   mesela loglarımızı bir dosyada, bir veri tabanında, bir sms olarak atabilirsiniz örneğin birisi bir krediye başvuru yaptığı zaman ona sms gitmesi bir süreç, ona mail gitmeside, bizim kendi sistemimizde bir dosyaya yazmamızda, bir veri tabanınıa yazmamızda bir loglama alternatifleri diyebiliriz.
   bakınız hepsi logluyor yani hepsinin imzası aynı ama dosyaya yazarken dosyaya yazma kodları, veri tabanına yazarken veri tabanına yazma kodları, sms yollarken sms yollama kodlar, mail yollarken eposta yollama kodları yazılır yani imza aynı ama kodlar farklı ama hepsinde yapılan işlem loglamadır.
   o zaman biz yukarıdaki oluşturduğumuz 3 kredili sisteme bir loglama enjekte edelim ancak en başta buna nasıl karar vereceğiz ? 
   alternatif sistemler var, veri tabanına yazma, e posta yollama, sms gönderme, dosyaya yazma bakınız bunlar alternatif sistemlerdir hatta bazen de alternatif sistem olduğunu bilmezsin tek sistem vardır o da veri tabanına yazma başka bir şey istenmez iç müşteri tarafından(ilgili birimler) böyle durumlarda bile biz ona interface ekleriz bununla ilgili birazdan hayati kuraldan bahsedeceğiz şimdi bir interface ekleyelim ILoggerService adında ve oradan devam edelim.     
   Not bundan sonra interface oluşturacağımız da sonuna Service ekleyeceğiz kuralı budur. ILoggerService for example



    
   
   */
}
