using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager taksitKrediManager = new TaksitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService() };


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisi(),loggers);//Direk burda da new leyerek Ekleyebiliriz..


            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,taksitKrediManager};

            //basvuruManager.KrediOnBilgilendirmeYap(krediler);

            

        }
    }
}
