using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // naming convention

        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Tebrikler..Sepete eklendi : " + urun.Adı);

        }

        public void Ekle2(string urunAdi, string urunaciklama, double fiyat, int stokAdedi) 
        {
            Console.WriteLine("Tebrikler..Sepete eklendi : " + urunAdi);

        }

    }
}
