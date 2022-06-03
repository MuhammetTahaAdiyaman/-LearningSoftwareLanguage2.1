using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product //Entity -- varlık --> biz class isimlerine genellikle varlık isimleri veririz örneğin product == ürün ve class yapısı içinde ürünün ıd, fiyatını, adını vb. özelliklerini atayacağımız özelliklerimizi ekledik(prop) ile // prop --> property -- özellik
    {   // Bu tip class yapılarında sadece ve sadece özellik olur.
        //sıralama aşağıdaki gibi olması yarar sağlayacaktır kod okunabilirliğini arttırmak amacı ile.
        public int Id { get; set; } //bir nesneyi diğerinden ayırt edebilmek için veri tabanında kullandığımız numaradır. Tc gibi. Türkiyede birden fazla engin demiroğ olabilir ama birbirinden ayırmayı TcNo sağlıyor.

        public int CategoryId { get; set; } //ürünün hangi kategoride olduğunu tutmak istiyorum. Bundan dolayı kategorileride numaralandırma işlemi uygularız örn; bilgisayar kategorisi --> 1, yiyecek kategorisi --> 2 gibi. Neden direkt yazmıyoruzda böyle yapıyoruz, kategoriler değişiklik gösterebilir direkt kodu değiştirmektense veri kaynağını değiştirmek için bu şekilde kategorilize etmemiz gerekmektedir.        

        public string ProductName { get; set; }

        public double UnitPrice { get; set; } //ürünün fiyati

        public int UnitsInStock { get; set; } // ürünün stok adeti 

    }
}
