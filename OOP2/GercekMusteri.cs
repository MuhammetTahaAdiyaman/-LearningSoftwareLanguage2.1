using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Individual
    //Gerçek yani bireysel müşteri ile tüzel müşteri ikiside müşteri olsa da biz birbirinin yerine kullanmamız gerekiyor bundan dolayı burada bireysel müşteriye ait özellikleri oluşturacağız. TuzelMusteri.cs de ise tuzel müşterilere ait özellikleri oluşturacağız.
    class GercekMusteri : Musteri
    {
        
        public string TcNo { get; set; }
                
        public string Adi { get; set; }

        public string Soyadi { get; set; }

        

    }
}
