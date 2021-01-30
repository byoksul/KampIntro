using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Operasyonlar için..
    // Interface--Ara Yüz şablon..Birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız..
    //
    interface IKrediManager 
    {
        void Hesapla(int maas=4500,int kredi=50000);
        void BiseyYap();


    }


       
    
}
