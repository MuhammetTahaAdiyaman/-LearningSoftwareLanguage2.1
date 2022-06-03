using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Burada ürünlerimizi oluşturalım yeni oluşturma yöntemi göreceğiz.
            //ilk önce eski yaptığımız daha sonra yeni öğreneceğimiz daha sonradan c# eklenen bir özellik diyebiliriz.

            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; //mobilya kategorisi olsun
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //yukarıda öğrendiğimiz ürün oluşturma yöntemi ile yaptık şimdi aşağıda şu şekilde de ürün oluşturabiliriz.

            Product product2 = new Product { Id = 2, CategoryId = 5, ProductName = "Kalem", UnitPrice = 35, UnitsInStock = 10   }; // bu yapı ile de ürünlerimizi oluşturabiliriz yukarıdaki ile aynı mantığı taşır bir fark yoktur yazım farkı vardır yani class'ın yanında yukarıdaki gibi alanları ayrı ayrı vermeden direkt olarak süslü parantez içine tanımlayabiliyoruz. 

            //şimdi şöyle bir açıklama yapalım gerçek hayatta biz bir product oluşturup alanlarını biz elle mi veriyoruz tek tek kendimiz mi atıyoruz ? Hayır. şu anda bir simülasyon yapıyoruz. Biz bunu bir web uygulaması veya mobil uygulama ile birleştirince aslında biz buradaki örneğin 2yi, örneğin masayı, örneğin 500 tl yi, örneğin 3 adeti ekranda kullanıcıdan alırız. örnek olarak --> product1.ProductName = "Masa"; yerine gerçek hayatta product1.ProductName = tbxProductName.Text (yani kullanıcının oraya girdiği değer) anlamına gelmektedir. Şimdi burada öğrenmek amacı ile elimizle giriyoruz ama angular ile kullanıcıdan bir ekran yolu ile alacağız bu değerleri.   
            //şimdi diyelim ki elimizdeki bir ürünü eklemeyi simüle etmek istiyorsunuz zaten bunun için yapılmış bir classımız var bizim ProductManager.cs işte bu class içinde Add fonksiyonu-methodu-operasyonu ile ekleme işlemini simüle etmek istiyoruz aynı yukarıda ürün1 ve ürün2 oluşturduğumuz gibi buraya çağırmamız için bu fonksiyonu ilk önce class örneğini oluşturup (instance creation) daha sonra methodumuzu çağıracağız bu aynı şu şekilde string isim = "Taha"; --> biz burada string türünde isim adında bir tane değişken tanımlıyoruz aynı şekilde ProductManager türünde productManager tanımlıyoruz gibi düşünelim aşağıda örnek olarak gösterelim.

            //PascalCase --> kelimelerin ilk harfi büyük yazılınca class anlamı taşır -- ProductManager || camelCase --> kelimelerin ilk harfi küçük sonraki harfi büyük olur productManager.
            //case sensitive --> küçük büyük harf duyarlı.
            //geçen ders gördüğümüz referans tipleri(class, array vb.) oluşturabilmemiz için "heap" kısmında newlememiz gerekiyordu. Stack bellekte olan productManager, new diyerek yeni bir referans numarası almıştır diyebiliriz Heap kısmı için. ProductManager productManager --> stack || new ProductManager (); --> heap
            ProductManager productManager = new ProductManager();
            productManager.Add(product1); //bunu bir buton olarak düşünelim e-ticaret sisteminde buna tıklayınca ürün eklendi demesi için bu parantez içine ürün yerleştirmemiz gerekmektedir. İşte bu ürünü yerleştirebilmemiz içinde ProductManager.cs ye gidip orada Add methodumuza parametre olarak ürünü eklememiz gerekir (Class olarak eklememiz gerek yoksa kendimiz atayarak eklersek geçen derslerde gördüğümüzde bir ürün güncellemesi anında bir çok eror ile karşılaşacağız). 
            //biz ProductManager.cs de Add methodumuza parametre olarak Product product, yani Product tipinde product gelsin öyle çalışayım dedirttik bundan dolayı burada rahatlıkla Product türünde product1'i ekleyebiliyoruz eğer biz oraya direkt olarak parametreye string productName, int UnitPrice olarak ekleseydik bu sefer bu veri tiplerine uygun olan değerler atayacaktım buradaki parantez içine. Bir nevi Add methodu diyor ki ben Product tipinde product tutuyorum yani sen product1 i ProductManager classı içinde Add methoduna gönderiyorsun ben product1 'i product olarak orada tutuyor olacağım diyor.

            /*
             Not = referans tipler hakkında burada bir not ekleyeceğim. çünkü burası önemli yukarıda anlattığım herşey. çünkü burayı bilmeyen sektörde fazlaca insan var
             
            1-) bunu anlayabilmemiz için ilk önce ProductManager.cs ye gidelim yeni bir BiseyYap adında bir method oluşturalım parametre olarak da sayi ekleyelim. daha sonra buraya geleceğiz.
            2-) methodumuzu oluşturduk. 
            3-) burada bir tane sayi tanımlayalım BiseyYap methodumuza da parametre olarak int sayi girdiğimiz için method da sayi isteyecek. 
            int sayi = 100; 
            4-) şimdi aşağıda methodumuzu çağıralım. Yukarıda zaten ProductManager classımızı çağırdığımız için direk olarak . ile methodumuzu çağırabiliriz. Bu method bizden bir sayi istediği için ona sayiyi veriyoruz.
            ProductManager.BiseyYap(sayi);
            5-) şimdi ProductManager.cs e geçelim orada oluşturduğumuz BiseyYap methodumuz içine de bir tane sayi tanımlayalım ama buradaki tanımladığımız sayıdan farklı bir sayı olsun ayırt edici olsun diye.
            6-) methodumuz içinde ki sayimiz --> sayi = 99 yaptık.
            7-) şimdi bir uzmanlık sorusu aşağıda anlatacağım.
            **********
            int sayi = 100;
            ProductManager.BiseyYap(sayi);
            Console.WriteLine(sayi); 
             
            şimdi burada tanımladığımız sayımız 100 daha sonra bu sayıyı biz BiseyYap methodu içine gönderdik orada sayımız 99 oldu şimdi soruya gelelim son olaak yazdığımız Console.WriteLine(sayi); sonucumuz nedir?
            cevap = 100 nedenini en alttaki cümleden sonra açıklayacağım.
            
            ************* 
            
            şimdi diğer bir soru yukarıda tanımladığımız add methodumuz vardı ürünlerimizi oluşturmuştuk product1 ekrana bastıracaktık. Şimdi biz Add methoduna gidelim ve oraya product.ProductName = "Kamera"; olarak yazalım. yani şöyle olacak.
             
            ProductManager.Add(product1)
            Console.WriteLine(product1.ProductName);
             
            şimdi bizim product1.ProductName = "masa"; idi. biz add methodu içinde product.ProductName = "Kamera"; olarak belirledik;
            soru = Console.WriteLine(product1.ProductName); bu kodu çalıştırdığımızda product1'in ProductName'i masa mı ? yoksa kamera mı ? olacak. yukarıdakinden neden farklı oldu normalde biz masa diye atama yaptık, daha sonra method içinde bunu kamera olarak değiştirdik yine buraya geldik sadece product1 in ProductName ini bastırınca nasıl masa değil kamera olarak bastırıyor.
            cevap = burada ki cevap ise masa değil kamera olacak neden bu şekilde olacak bunu aşağıdai cümleden hemen sonra anlatacağım
            
            **************
             
            yukarıda sorduğumuz iki sorunun da cevabını verdikten sonra bu cümlenin altına açıklamaları ile birlikte anlatacağım. Şimdi cevaplarını verelim.
            //Hatırlayalım geçen derste referans ve değer tipler hakkında konuşmuştuk neydi onlar;
            // int, double, bool .... --> değer tip
            // array, class, abstract class, interface --> referans tip
            // bu yukarıda yazdığımız referans ve değer tiplerin nasıl çalıştığın geçen dersimiz olan degervereferans tip dersinde anlattık.
           ****
            //** Ancak şöyle bir şey söylemiştik değer tiplerde atamalar tamamen değei üzerinden olur ve bütün bağlantı kopar şimdi 1.sorumuzun cevabını açıklayalım 
            1-)biz int sayi = 100 dediğimizde, BiseyYap fonksiyonuna int sayıyı yolladığımızda aslında ne oluyor siz oraya sadece sayının değerini yolluyorsunuz. sayıyla olan (int sayi = 100;) bütün bağlantınız o değeri verdikten sonra bitiyor.  
            2-) o yüzden BiseyYap methoduna gönderdiğimiz 100 değeri parametre içinde yazdığımız int sayi'ya eşitleniyor.
            3-) daha sonra int sayiya eşitlendi ya orada bağımsız olan ve değeri 100 olan sayiyi 99 yapmış olduk. int sayi = 100; ile alakası olmadığından dolayı bastırdığımızda sonucu 100 olarak aldık. yani kısaca özetlersek int sayi = 100; 'ün değeri olan 100 ü aldık methoda gönderdik orada 99 oldu ancak değeri gönderdikten sonra int sayi ile olan bağlılık devam etmiyor sadece değeri  o methoda gidiyor, biz yeniden sayi'yi yazdırdığımızda bağlantısı olmadığı için 100 değerini ekranımızda görüyoruz.
           ****
            //** Ama referans tiplerde herşey yani atamalar referansın numarası ile yapılır demiştik. yani bellekteki adresi ile yapılır.
            1-)biz ProductManager'a Add deyip product1'i yolladığında aslında, new ProductManager(); oluşturduğumuz örneğin bellek adresi 101 olsun, yani biz 101 referans adresi üzerinden gidiyoruz hakikaten bellekteki yerine referans vererek gidiyoruz.
            2-) productManager.Add(product1); --> yani buraya product1'i yolladığımızda buraya 101 numaralı bellek adresini yolluyoruz. bellekteki fiziksel bir lokasyonu yolluyoruz diyebilirim.
            3-) dolayısı ile 101 numaralı yerde bulunan product'ın ProductName = "Kamera" yaptık. yani şu anda 101'in ProductName'i kamera yani her şey referans numarasına göre gidiyor.
            4-) artık biz Console.WriteLine(product1.ProductName) --> burada product1 'in ProductName'ini bir daha okuduğumuzda bu adam zate 101 di, 101 adresinde ki değer kamera olduğu için kamera basmış olduk burada masa atasan bile artık 101 adresine eşitlendiği için. 
            

            Unutma = Bundan sonra artık biz her zaman bir class ataması yapacağımız zaman onu bu yukarıdaki şekilde veya bir önceki ders olan DegerVeReferans tip de anlatılan gibi referans numarası üzerinden atamayı aklımızın bir köşesinde tutuyor olacağız. 
             */

            productManager.Topla2(3, 6);

            int toplamaSonucu = productManager.Topla(3, 6); //productManager.Topla(2,3) == return sayi1+sayi2 --> return kısmı yani sonuç. Daha sonra biz bu sonucu int toplamaSonucuna eşitliyoruz. artık direk sonucuda bastırabiliriz istersek bu sonucu iki katına da çıkartabiliriz ancak bunu void fonksiyonu ile yapamazdık çünkü o emir kipi ile çalışır.
            Console.WriteLine(toplamaSonucu); //burada direkt olarak 6+3 toplamını ekrana bastırdık işte istersek sonucu iki ile de çarpabiliriz return fonksiyonu sayesinde

            Console.WriteLine(toplamaSonucu*2);//burada bir değeri aldık gittik sistemde hesaplattık, 

            /*Not: Kısa bir özet void ile return fonksiyon farkını
             
            void fonksiyon --> kısaca emir kipi methodu ile çalışan bir fonksiyondur yani git-yap-bitir bunu örnekle anlatayım;
            productManager.Topla2(3,6); --> bu kodu yazdık bu kod bizi Topla2 methoduna götürecek orada int sayi1 = 3, int sayi2 = 6 atayacak ve süslü parantez içinde ki kodu çalıştıracak yani bu değerleri toplayacak ekrana bastıracak ve görevi bitecek.
            
            return fonksiyon --> yukarıdaki örnekte verdiğimiz toplam sonucunu biz başka bir method içinde kullanmak veya o toplam değeri 2 ile çarpmak istersek bu mümkün olmayacaktır bunun için return fonksiyon kullanıyoruz. örnek ile açıklayalım banka sistemi düşün orada krediler hesaplanıyor başka yerlerde de o hesaplanan krediyi işleme sokabiliyoruz işte bunu return fonksiyon ile kullanım sonucunda olduğunu düşünelim aşağıda bir örnek verelim yukarıdaki gibi;
            productManager.Topla(2,3) == return sayi1 + sayi2 --> bu kısım return ettiğimiz değer yani döndürdüğümüz, sonucumuz. şimdi burada direkt ekrana basmayacak çünkü biz sadece sonucu döndürdük ekrana basmamız için bunu bir değişkene atamamız gerekecek işte bu değişken sayesinde farklı farklı yerlerde kullanabileceğiz hemen değişkene atayalım;
            int toplamSonucu = productManager.Topla(2,3) --> burada değişkene atamış olduk şimdi bu methodumuzun sonucunu ekrana bastıralım daha sonra sonuç üzerinde farklı oynamalarında örneğini aşağıda yazacağım
            Console.WriteLine(toplamaSonucu) --> bu sayede ekranımıza 9 değerini basmış olduk. 
            şimdi toplam değeri 2 ile çarpalım ve ekrana bastıralım;
            Console.WriteLine(toplamSonucu*2);

            işte biz bu int toplamSonucu değerini farklı methodlar içinde de kullanbilme özelliğine sahip olduk artık.

             */

        //şimdi yeni konumuz olan koleksiyonlar yardımcı konumuzu göreceğiz.
        }
    }
}
