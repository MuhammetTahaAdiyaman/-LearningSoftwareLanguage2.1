using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{//bu class'ı operasyon-method tutmak için oluşturulmuştur. Burada sadece operasyonları yöneteceğiz.
 //Manager Sınıfları --> business class -->İş sınıfları = kuralları yazarız.
    class MusteriManager
    {
        public void Ekle(Musteri musteri) //bu ekle metodu parametre olarak ne atayacağız yani biz veri tabanına ne kaydedeceğiz bir müşteri o zaman parametre olarak da class olan Musteri şeklinde atayalım bunun avantajını geçen derslerde konuşmuştuk sayfaların error alma durumu konusunda avantajlı daha hızlı ve çözümcül olduğundan dolayı parametreleri genellikle class olarak atıyoruz.
        {
            //if (musteri.) bu tarz kodlar yazılır.
            //{

            //}

            //**Biz bu method parametresine class olan Musteri isminde bir class istedik ama biz hem tüzel hem de gerçek müşteriyi bu ekle metoduna parametre olarak gönderebilmek istiyorum çünkü ikiside benim müşterimdir. Bunun içine ne yapacağız --> not aldığım kağıtlarda bu olayı gördük miraslama olayı yani inheratance bu class'ın yanına gidip şu şekilde yapıyorduk örneğin GercekMusteri : Musteri şeklinde. Biz bu ekle metoduna Musteri classını yazdık yani Musteri class'ı base class olarak aldık. Bu base class'ı hem TuzelMusteri hem de GercekMusteri class'ına intherit olarak atayalım.
            //**inheritance --> TuzelMusteri : Musteri = TuzelMusteri bir Musteri'dir demek aynı şekilde, GercekMusteri : Musteri = GercekMusteri bir Musteri'dir demektir. Biz bu yapıyı 3.gün derslerinde hocanın diğer ücretsiz kaynaklarından dinledim ve not çıkarmıştım orada öğrendim oradan da yardım alabilirim tekrardan.
            //**şimdi sıraylar hem TuzelMusteri ye hem de GercekMusteri'ye intherit olarak base class olan Musteri Class'ımızı atayalım.
            //**Bu inheritance'ın asıl olayını söylemek gerekirse --> Musteri class'ında olan özellikler artık GercekMusteri  ve TuzelMusteri'de de vardır anlamındadır. yani ortakları oraya atarız şeklinde ancak bu yeterli bir bilgi değildir asıl mantığını az sonra anlatacağız. TuzelMusteri intherits-miras alır Musteri'den diyebiliriz. Kısacası bu TuzelMusteri'nin ebebevni Musteri'dir. Musteri'de olan herşey TuzelMusteri de de kabul edilir. Ama Musteri class'ı içinde şu anda bir özellik yok orada bulunan özellikleri Tuzel ve Gercek Musteri classlarına ayırdık. şimdi şu şekilde yapacağız Hem TuzelMusteri hem de GercekMusteri class'ında ortak olan Id ve MusteriNo ozelliğini Musteri class'ımıza geri alalım bu iki özellik GercekMusteri ve TuzelMusteri classlarında da ortak o zaman bu iki özelliği sadece Musteri classı içinde tutatım diğerlerinden kaldıralım.
            //**Şimdi şu şekilde; TuzelMusteri : Musteri --> bunun anlamı Musteri class ı içinde bulunan tüm özellikler TuzelMusteri'de de var kabul edilir çünkü nasıl okuyoruz TuzelMusteri bir Musteri'dir yani Musteri class'ıdır diyoruz. Yani 
            //şimdi GercekMusteri ve TuzelMusteri class'ı içinde ortak olan Id ve MusteriNo özelliklerini Musteri Class'ı içine geri atayalım ve Musteri class'ı içinde tutatılım.

        }




    }
}
