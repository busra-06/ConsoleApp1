using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        public void Add(Product urun)
        {
            Console.WriteLine("Sepete eklendi : "+ urun.Adi);
         }

        public void Add2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine( urunAdi);
        }
    }
}
