using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı");
        }
    }

    //şimdilik iki tane loglama sistemimiz olsun. biri DataBaseLoggerService, FileLoggerService şeklinde
    //yaptığımız şey sadece bir şablon oluşturmak(şablonu interface ile oluşturuyorduk ILoggerService) daha sonra ilgili class'ları(DataBaseLoggerService, FilerLoggerService) o şablondan implemente etmek. o şablona her iki yerde de uymak zorundayım artık.
    //şimdi ben buraya DataBaseLoggerService den geldim buradan da BasvuruManager.cs ye gidelim orada ve implemente ettiğimiz metodu aynı zamanda orada kullanalım (parametre bölümüne ILoggerService ekleyerek)

}
