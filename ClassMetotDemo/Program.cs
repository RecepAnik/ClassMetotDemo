using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.musteriId = 001;
            musteri1.musteriAdi = "Recep";
            musteri1.musteriSoyadi = "Berk";
            musteri1.musteriBakiye = 500;


            Musteri musteri2 = new Musteri();
            musteri2.musteriId = 002;
            musteri2.musteriAdi = "Sena";
            musteri2.musteriSoyadi = "Gün";
            musteri2.musteriBakiye = 950;


            MusteriManager musteriManager = new MusteriManager();


            musteriManager.liste(musteri2);
            // musteriManager.ekle(musteri1);
            // musteriManager.sil(musteri2);
        }
    }
}
