using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{//biz bir ILoggerService interface oluşturmuştuk işte biz veri tabanına loglama yapacağımız için burada bu class'ı ona alternatif yapacağız nasıl yapıyorduk referansını vererek yani aşağıda gösterelim 7.satırda.
    class DataBaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veri tabanına loglandı"); //burayı veri tabanı için loglama için kullandık şimdi aşağıda dosya için loglamayı gösterelim aynı class yapısını kopyala ismini değiştir. daha sonra yeni bir class yaptığımız için FileLoggerService ismine bir kere tıkla ampül den move to new file a tıkla OOP3 içinde yeni bir class dosyası şeklinde oluşacaktır.
        }
    }

    //class FileLoggerService : ILoggerService
    //{
    //    public void Log()
    //    {
    //        Console.WriteLine("Dosyaya Loglandı");
    //    }
    //}

}
