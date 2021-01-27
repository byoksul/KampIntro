using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();

            musteri1.MusteriNo = "1234";
            musteri1.Id = 2;
            musteri1.Adı = "Engin";
            musteri1.Soyadı = "Yoksul";
            musteri1.TcNo = "32412341234";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.MusteriNo = "2314123";
            musteri2.Id = 3;
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "131231231";


            //gerçekmüşteri - Tüzel müşteri
            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);


             
        }
    }
}
