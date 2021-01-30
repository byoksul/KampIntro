namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDic<int, string> lise = new MyDic<int, string>();

            lise.Add(1, "KULELİ ASKERİ LİSESİ");
            lise.Add(2, "MALTEPE ASKERİ LİSESİ");
            lise.Add(3, "IŞIKLAR ASKERİ LİSESİ");
        }
    }
}