using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //Naming convention - İsimlendirme kuralı
        //Syntax - Yazış şekli
        public void Ekle(Urun urun)//1. Urun, tipini; 2. urun, isimlendirmeyi gösterir.
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
    }
}
