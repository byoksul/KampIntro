using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string okul1 = "Kuleli";
            string okul2 = "maltepe";
            string okul3 = "bando";

            // array- diziler

            string[] okullar = new string[] {"Kuleli","maltepe","bando"};


            for (int i = 0; i < okullar.Length; i++) 
            {
                Console.WriteLine(okullar[i]);

            }

            Console.WriteLine("FOR döngüsü bittii..");


            foreach (string okul in okullar) // diziler  içinde kolay gezmek için..
            {
                Console.WriteLine(okul); 

            }

            Console.WriteLine("sayfa sonu..");

        }
    }
}
