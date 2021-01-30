using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class EsnafKredisi : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla(int maas,int kredi)
        {
            if (maas * 17 < kredi)
            {
                Console.WriteLine("Kredi Alamazsınız.");
            }
            else
            {
                Console.WriteLine("Alabilirsiniz");
            }
            
            Console.WriteLine("Esnaf Kredisi Uygulandı..");
        }

        
    }

}
