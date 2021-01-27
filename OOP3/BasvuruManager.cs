using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection---Methodu burada enjekte ediyoruz..
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices) 
        {
            //Basvuranbilgilerini degerlendirme
            //...

            
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();

            }

        }

        public void KrediOnBilgilendirmeYap(List<IKrediManager> krediler) 
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();


            }
        }   

    }
}
