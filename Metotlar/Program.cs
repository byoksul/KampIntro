using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdı = "AElma";
            double fiyati =25;
            string aciklama = "Amasya Elmasi";

            string[] meyveler = new string[] {"Elma","Karpuz"};


            Urun urun1 = new Urun();
            urun1.Adı = "Elma";
            urun1.Fiyati = 25;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adı = "Karpuz";
            urun2.Fiyati = 39;
            urun2.Aciklama = "Diyarbakır Karpuzu";


            Urun[] urunler = new Urun [] { urun1, urun2 };

            //type safe-- Tip Güüvenliği
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adı);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");

            }

            
            Console.WriteLine("----------Metotlar---------");
            
            // instance--örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            sepetManager.Ekle2("armut", "Yeşil", 24,14);
            sepetManager.Ekle2("elma", "Yeşil elma", 16,4);
            sepetManager.Ekle2("karpuz", "Yeşil karpuz", 46,32);

        }
    }
}



// tekrar tekrar kullanma
// dont repeat yourself - DRY :) - Best Practice :)