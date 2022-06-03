using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{//Loglama şablonunu yazalım şimdi interface içine. interface olduğu için sadece imza şeklinde yazabiliyoruz.
    //inteface içinde sadece imza metodları olur içi dolu olamaz.
    interface ILoggerService
    {
        void Log(); //benim şu anda şablonum loglama yapmak ama nasıl yapacağımızı birazdan belli edeceğiz.
        //örneğin sistemimde şu an ben veri tabanına log yapmak istiyorum bundan dolayı şimdi bir class yapısı ekleyelim DataBaseLoggerService adında. dikkat burada kullandığımız interface ekleyeceğimiz class yapısı olacak 
        
    
    }
}
