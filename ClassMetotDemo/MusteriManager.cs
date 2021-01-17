using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void ekle(Musteri musteri) {

            Console.WriteLine("Sayın "+musteri.musteriAdi+ " "+ musteri.musteriSoyadi +", Para Eklendi.");
        
        }
        public void sil(Musteri musteri)
        {

            Console.WriteLine("Sayın " + musteri.musteriAdi + " " + musteri.musteriSoyadi + ", Para Çıkışı Oldu.");

        }
        public void liste(Musteri musteri)
        {

            Console.WriteLine("Sayın " + musteri.musteriAdi + " " + musteri.musteriSoyadi + ", Hoşgeldiniz.");

        }

    }
}
