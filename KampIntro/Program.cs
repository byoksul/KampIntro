using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety - veri güvenliği
            string katagoriEtiketi = "Katagoriler";
            int ogrenciSayisi = 35000;
            double faizOranı = 20.34;
            bool sistemeGirişYpamışMı = false;
            double dolarDun = 7.55;
            double dolarBugün = 7.55;

            if (dolarDun > dolarBugün)
            {
                Console.WriteLine("Azalış");

            }
            else if (dolarDun < dolarBugün)
            {
                Console.WriteLine("Artış");
            }
            else
            {
                Console.WriteLine("Değişim yok..");
            }

            if (sistemeGirişYpamışMı== true )
            {
                Console.WriteLine("Kullanıcı Ayarları");
            }
            else
            {
                Console.WriteLine("Giriş Yapmadınız..");

            }

            //Console.WriteLine(katagoriEtiketi);
            //Console.WriteLine(ogrenciSayisi);
            //Console.WriteLine(faizOranı);


        }
    }
}
