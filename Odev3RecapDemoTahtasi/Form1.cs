using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev3RecapDemoDamaTahtasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {//basta ekleyeceğimiz butondan 64 tane 8x8 oluşturmamız gerekiyor. Biz bir buton koyduğumuzda bir class'dır görsel karşılığı butondur. 
         //Button button = new Button(); //bir tane buton nesnesi oluşturmuş olduk.
         //button.Width = 50;
         //button.Height = 50;//bir butonun birden fazla özelliği olduğunu bu şekilde görebiliyoruz.
         //this.Controls.Add(button);
         //bizim amacımız 8x8 buton oluşturmak evet ilk akla for döngüsü ile yapabiliriz diyorsun ancak for döngüsü ile üst üste 64 buton oluşturacak ve butonların referansını kaybetmiş olacaktık daha sonra buton ile ilgili bir işlem yapacağımızda hata almamıza sebeb olacaktı bundan dolayı aşağıdaki yöntemi uygulamamız gerekmektedir.
         //bundan dolayı nesneyi array şeklinde oluşturmamız daha doğru olacaktır yukarıyı yorum satırına alıyorum şimdi aşağıda devam edelim.

            Button[,] buttons = new Button[8,8]; //[64] olarak da yazabilirdik ama formumuz 8x8 olduğu için [8,8] şeklinde oluşturduk
            //bu şekilde yaptığımızda butonların referanslarını da kaybetmemiş olacağız örneğin 3.satırın 3.butonuna erişim dediğimiz zaman ulaşabilecğeiz aksi takdirde diğerinde hangi buton ne belli değil. 
            //her satır için 8 butonlu bir döngü tasarlamamız gerekiyor birinci satır için 8 buton 2.satır için 8 buton gibisinden.
            int top = 0;
            int left = 0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++) //neden 0 yazdık [0,1] köşeli parantez içinde ilk değer 0.boyut altta yaptığımız for döngüsünde ise 1.boyut yani köşeli parantez içinde 2.değer için döngümüzü oluşturduk 8x8 olması için.
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button(); //[i,j] 0'a 0 için konuşuyoruz burada 0'a 1, ..., 0'a 8, sonra 1'e 1, ..., 1'e 8 gibi ilerleyecek dolayısı ile burada bir nesne var ve nesneyi kullanabilmemiz için ilk buton bizim için yeni bir butondur ikinci butonda öyle bundan dolayı her seferinde yenilememiz gerekiyor.  
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left; //45.satırdan geliyorum şimdi bu bizim ilk buton yerimiz yani en dib olan 0 noktamız bir sonraki buton eklediğimizde 50 karakter sağdan başlatmamız için ne yapmamız gerekiyor aşağıda yapalım hemen.
                    buttons[i, j].Top = top;
                    left += 50;
                    this.Controls.Add(buttons[i, j]); //biz bu şekilde yaparsak üst üste kondurtacağız ne yapmamız gerekiyor ilk butonu koyduktan sonra sağa doğru 50 karakterden sonra başlatmam gerekiyor yukarıda ilk yaptığımızda da üst üste koyuyordu ne farkı var burada butonları oluşturduktan sonra referanslarını kaybetmiyoruz bundan dolayı bu şekide oluşturduk. 
                    //sağa doğru 50 karakter yazdırmak için yukarıda top ve left şeklinde değişken tanımlayalım.
                    //top ve left değerlerini tanımladıktan sonra burada [i,j] de kullanalım 4 satır yukarıda.
                    //41-42.satırdan geliyorum şimdi dama tahtası yazıyoruz ya bir beyaz bir siyah yapmamız gerekcek peki bunu nasıl algoritma haline dönüştüreceğiz aşağoda gösterelim.
                    if ((i+j)%2==0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                }
                //left satırları bitirdiğimizde yani 2.satıra geçtiğimizde yine en dib noktadan başlaması için burada left = 0 yapmamız gerekiyor.
                top += 50; //peki neden parantez dışı yapıyoruz nedeni ikinci satıra geçtiğimizde veya 3.satıra geçtiğimizde 50 artarak aşağı gitsin mantığından dolayı buraya yazıyoruz. left = 0 yazmamızın sebebi ise 2.satır veya 3.satır yani yeni satır olduğunda yine buton başlangıç noktası 0 olsun diye bunu yaptık.
                left = 0; //ilk gördüğümüzde 8 buton var gibi ancak üst üste koyduğu için farketmedik o yüzden ne yapmamız gerekiyor aynı left de gibi top'ı da 50 arttıralım ki alt alta da 8 tane buton olsun 8x8 yolunda. o yüzden bir üst satıra top += 50 yazarsak üst üste değil aşağı doğru butonlarımız yerleşecektir.
            }
        
        
        }
    }
}
