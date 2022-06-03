using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Musteri
    {//Class'ların 2 tane kullanım özelliği vardır. ilki yani burada ki gibi içerisinde özellikler tutardı. İkincisinde ise operasyonlar tutardı. Özellik tuttuğumuz yerde operasyon tutmuyoruz, operasyon tuttuğumuz yerde özellik tutmuyoruz.
     //Bir musterinin hangi özellikleri olabilir. Class ismine dikkat edelim Musteri yani tekil bir insanı anlatacağız aşağıda. Müşterinin adı, soyadı, tcno, vergi no, şirket ismi gibi özellikler olabilir. Şimdi burada da dikkat etmişizdir özellikleri sayarkende hem tcno dedik hem vergino dedik, hem müşteri adı dedik hem şirketadı dedim bundan sonra şu şekilde ilerleyeceğiz ilk önce kötü kodu yazacağız ve bu kötü kodun neye sebebiyet vereceğini öğreneceğiz ve burada interehance'ı anlatmaya çalışacağız. şimdi bize problem yaratacak seviyede bir nesne üretiyoruz. 

        //public int Id { get; set; }

        //public string MusteriNo { get; set; }

        //public string Adi { get; set; }

        //public string Soyadi { get; set; }

        //public string SirketAdi { get; set; }//Ama müsteri sirket de olabilir o zaman sirket adını da ekleyelim;

        //public string TcNo { get; set; }

        //public string VergiNo { get; set; }

        //neden vergino, müşterino, tcno gibi ifadeleri long tanımlamak yerine string aldık halbuki sayısal ifadelerden oluşuyor. eğer bir veri üzerinde matematiksel işlem yapmıyorsan toplamıyorsan, çıkarmıyorsan, çarpmıyorsan, bölmüyorsan yani ona sayı görevi vermiyorsan bunlar metinsel olarak planlanırsa daha iyi sonuçlar alırız özellik farklı sistemler ile veri uyumluluğunda çünkü biliyorsunuz farklı yazılım ortamlarında bu sayıların karşılıkları veya sınırları farklılık gösterebiliyor bundan dolayı oralarda sorun yaşamamak yerine bu şekilde kullanım tercih edilir. Örneğin sayısal bir tcno'yu gidip excele atınca excel de garip garip karakterler görürüz çünkü veri uyumsuzluğu oluşur.  
        //Not = şimdi 8.satırda bahsettiğimiz yanlış kullanım adına bir şey demek istiyorum. eğer ki bir nesnede bir değeri kullanmak zorunda gibi görünmüyorsan o nesneye ait değilmiş gibi duruyorsa o alan demekki orada soyutlama hatası yapıyorsun diyebiliriz. ne demek istiyoruz şimdi program.cs ye geçelim orada devam edelim 
        //Bu yukarıdaki özellikleri TuzelMusteri ve GercekMusteri olmak üzere 2 ayrı classlara paylaştırdık. program.cs de açıklamasını yaptım.

        //Inheritance mantığından dolayı buraya Hem GercekMusteri hem de TuzelMusteri class'lar içinde ortak olan Id ve MusteriNo özelliklerini geri buraya aldık çünkü biz Musteri classımızı base class olarak belirledik ve diğerlerine miras verdik artık burada olan ozellikler hem GercekMusteri hem de TuzelMusteri class'ları içinde de olacak Inheitance mantığı sayesinde(Musteri --> ebebevn)
        public int Id { get; set; }

        public string MusteriNo { get; set; }

        //Biz bu inheritance yapısı sayesinde TuzelMusteri class'ı içinde sadece ona ait özellikler, GercekMusteri class'ı içinde sadece ona ait özellikler ve bu Musteri class'ı içinde ortak olan özelliklerimizi tuttuk. Musteri class'ını ebebevn yani base class olarak belirlediğimizden dolayı Musteri class'ı içinde olan özellikler her ikisinde de olmuş olacaktır bu mantık sayesinde ( GercekMusteri : Musteri // TuzelMusteri : Musteri)
        //şimdi program.cs ye gidelim ve bu mantığı uygulama üzerinde görelim.
    }

}
