using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {


            Kurs kurs1 = new Kurs();
            kurs1.KursAdı = "C#";
            kurs1.KursunEgitmeni = "Burak YOKSUL";
            kurs1.IzlenmeOranı = 75;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "C++";
            kurs2.KursunEgitmeni = "Merve";
            kurs2.IzlenmeOranı = 100;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "python";
            kurs3.KursunEgitmeni = "Mahmut";
            kurs3.IzlenmeOranı = 30;

            // Console.WriteLine(kurs1.KursAdı + ":" + kurs1.KursunEgitmeni);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdı + ":" + kurs.KursunEgitmeni );

            }

        }
    }

    class Kurs
    {
        public string KursAdı { get; set; }
        public string KursunEgitmeni { get; set; }
        public int IzlenmeOranı { get; set; }
    }
}
