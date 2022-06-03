using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{ //Biz ürünün sadece özellikleri ile ilgileneceğimiz classımızı oluşturduk --> Product.cs
  //Şimdi bir e-ticaret sistemini düşünelim. E-ticaret sisteminde siz ne yapıyorsunuz ? örneğin ürünleri listeliyorsunuz, ürün arıyorsunuz, ürün ekliyorsunuz, ürün güncelliyorsunuz, ürün siliyorsunuz bu tip hareketler yapıyoruz. Bu tür işlemlere CRUD --> CREATE, READ, UPTADE, DELETE operasyonlara deniliyor. İşte bu tür operasyonları da ProductManager classı içinde yani bu class içinde yapacağız. Yani ikiye böldük, ürün özellikleri için --> Product.cs || CRUD operasyonları için --> ProgramManager.cs
  //genellikle biz bu operasyonları method yöntemi ile gerçekleştiririz. Aşağıda yapacağız şimdi.
    class ProductManager
    {
        public void Add(Product product) //şimdi bir mantık kuralım. Biz bir ürün ekleyeceksek, bu ekleme operasyonumuza neyi ekleyeceğimizi söylememiz gerekmez mi. Bundan dolayı parametre olarak bir product girelim ancak bunu class olarak parametremizi girelim eğer direk kendimiz şu şekilde atarsak Add(string ProductName, int UnitPrice vb.) gibisinden atamaya çalışırsak geçen derslerde gördüğümüz şekilde bir güncelleme anında tüm sayfalarda eklenecek veya kaldırılacak özelliği tek tek eklemek demek 100lerce kodun değişmesi demek ve tüm sayfalarda eror almamızı sağlayacak bu da dinamiklik için önemli eksikliktir ancak class ile parametremizi alırsak, Product.cs yapısı içinde güncellememizi yaparız ve eror almadan dinamik şekilde ürün hakkında güncelleme sağlanacaktır. Birde buraya class olarak yazmamızın dieğr bir sebebi encapsulation olayıydı, 50 tane parametre yazmak yerine tek parametre içinde 50 özelliği kullanabilmek için.
        {//biz bu şekilde bir parametre yazdığımızda anlam şu şekilde bu fonksiyonu-methodu-operasyonu kullanabilmek için bana bir tane product vermelisin. --> program.cs de.
            //product.ProductName = "Kamera"; (Not kısmında soru için yazdığımız kod)
            Console.WriteLine(product.ProductName + " eklendi."); //şimdi bu program.cs de not dan sonra ki kısım için yazdığımız bölüm için.
        }

        /*
        public void BiseyYap(int sayi)//program.cs de not bölümü için hazırladığımız bir methoddur.
        {
            sayi = 99;
        }
        */

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        /*Not = yukarıda iki fonksiyonu da kurduğumuz anahtar kelime olan void nedir, ne işe yarar bundan biraz bahsedelim;
        Void = void diye belirttiğimiz methodları şu şekilde düşünebiliriz, siz diyorsunuz ki emir kipinde git ekle (Add metodu için), git güncelle(Uptade methodu için), git sil, tamamen bunu söylüyorsunuz ve onu bir emir kiğinde çağırıyorsunuz ve o işlemini yapıyor ve bitiriyor. Bizim bu işlem sonucunda ne olduğu ile ilgili ekstra bir bilgiye ihtiyacımız olmadığı zaman onu void olarak tanımlıyoruz. 
        --> diğer method türünü hemen aşağıda gösterelim örnek olarak ve altına açıklamasını yapalım.
        */

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);        
        }

        /*Not2 = yukarıdaki iki methodumuzu öğrenirken öğrencilerin çıldırdığı kafalarının yandığı konuya geldik bu ikisi arasındaki farklardan bahsedeceğiz;
        yani ben Topla methodunu void fonksiyonu ile yazsam ne olur, return fonksiyonu ile yazsam ne olur? şimdi bunu açıklayalım;

        1-)şimdi program.cs ye gidelim topla 2 metodunu çağıralım.
        -productManager.Topla2(3,6); kodunu yazdık. bu Topla2 ne yapıyor program.cs den bu Topla2 methoduna gelir int sayi1 = 3, int sayi2 = 6 olur daha sonra 3 ile 6 yı toplar = 9, 9'uda ekrana yazar. Aslında amacına ulaştın mı evet ulaştın.
        -şimdi ne yaptık burada yukarıdaki Topla2 operasyonu vasıtasıyla ekrana bir şey yazdırmak oldu. 

        2-)şimdi neden return'e ihtiyacımız var ? bunu bir bankacılık uygulaması üzerinden anlatalım;
        -Bankacılık uygulamasında krediyi gider hesaplarsınız, ortaya çıkan sonucu başka bir yerde bir daha kullanırsınız kısacası Topla2 methodu sonucunda ortaya çıkan toplam varya o toplamı ben başka bir şeyde daha kullanmak istiyorum örneğin toplamı bu sefer de 2 ile çarpmak istiyorum. aşağıda gösterelim
        -Topla2 methodunun yaptığı hareket iki süslü parantez içinde olan değeri ekrana yazmaktı, ama biz yukarıda diyoruz ki yani bana topla daha sonra topladıktan sonra o değeri ver bana çünkü programın akışında bana lazım ben kullanacağım onu yani başka methodda onu çağırabilirsin işte Topla2 yani void li method da bunu yapmam mümkün değil çünkü void sadece emir kipiydi, git-yap-bitir mantığı ile çalışıyordu. gidip- yapıp-bitirince bağlantın bitmiş oluyor yani bunu başka bir method içinde kullanamayaız. Ama bizim onun dönüşüne ihtiyacımız var yani bu Topla2 sonucunda ortaya çıkan değere ihtiyacım var. Bundan dolayı biz return fonksiyonları kullanırız şimdi aşağıda açıklamanın devamı var;       
        -public int Topla  methodu şu demek --> bu metodu yani Toplayı çağırırsan ben sana int tipinde bir şey veririm demek return sayi1+sayi2 --> sayi1 ile sayi2 yi toplar veriyorum zaten o da int tipinde zaten bu kurala uymak zorundayım public int topla deyip return den sonra kafamıza göre string (return "aaaa";) yollayamayız.
        -yani program akışında bana o değer lazım şimdi program.cs ye gidelim int Topla methodunu çağıralım ve nasıl ekrana yazdırıyoruz görelim. void methodundan farklıdır çünkü void metodu iki süslü parantez arasındaki kodu ekrana bastırır ancak return fonksiyonda ekrana return edilen değeri bastırmamız için ilk önce bir değişkene atamamız gerekmektedir.
        int toplamaSonucu = productManager.Topla(3,6);
        Console.WriteLine(toplamaSonucu);
        -şimdi yukarıdaki kodun açıklamasını yazalım program.cs de de yazacağız. 
        -int toplamaSonucu = productManager.Topla(3,6); --> productManager.Topla() aslında bir fonksiyon ben ona 3 ve 6'yı verdim, topladı aslında return kısmı == productManager.Topla(3,2) olan yerdir. yani işlemin sonucu. bu sonucuda int toplamaSonucu'na atıyoruz. işte program sonucunda o değere ihtiyacım var return olan bölümü farklı methodlar içinde de kullanabiliriz mesela o sonucu 2 ile çarpmak istersek eğer;    
        Console.WriteLine(toplamaSonucu*2); //yaparak return değerimizi yani sonucu iki ile çarpmış oluyoruz.
         
         */
    }
}
