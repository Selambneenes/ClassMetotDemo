using System;
using System.Linq.Expressions;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            {
                musteri1.Id = 11111;
                musteri1.Tc = 11111111111;
                musteri1.AdiSoyadi = "Arda Güngör";
                musteri1.Yasi = 21;
                musteri1.Sehir = "Denizli";
                musteri1.Meslek = "Şef";
                musteri1.Maas = 27000;
            }
            Musteri musteri2 = new Musteri();
            {
                musteri2.Id = 22222;
                musteri2.Tc = 22222222222;
                musteri2.AdiSoyadi = "Batuhan Balaç";
                musteri2.Yasi = 16;
                musteri2.Sehir = "Denizli";
                musteri2.Meslek = "Polis";
                musteri2.Maas = 12000;
            }
            Musteri musteri3 = new Musteri();
            {
                musteri3.Id = 33333;
                musteri3.Tc = 33333333333;
                musteri3.AdiSoyadi = "Yusuf Tolgay";
                musteri3.Yasi = 9;
                musteri3.Sehir = "Denizli";
                musteri3.Meslek = "Sanayi";
                musteri3.Maas = 8000;

            }
            Musteri[] musteriList = new Musteri[3] { musteri1, musteri2, musteri3 };

            MusteriManager musteriIslemleri = new MusteriManager();

            musteriIslemleri.Listele(musteri1);
            Console.WriteLine("-----------------");
            musteriIslemleri.Listele(musteri2);
            Console.WriteLine("-----------------");
            musteriIslemleri.Listele(musteri3);
            Console.WriteLine("-----------------"); 

            musteriIslemleri.Ekle(musteri1);
            Console.WriteLine("-----------------");
            musteriIslemleri.Ekle(musteri2);
            Console.WriteLine("-----------------");
            musteriIslemleri.Ekle(musteri3);
            Console.WriteLine("-----------------");

            musteriIslemleri.Sil(musteri1);
            Console.WriteLine("-----------------");
            musteriIslemleri.Sil(musteri2);
            Console.WriteLine("-----------------");
            musteriIslemleri.Sil(musteri3);
            Console.WriteLine("-----------------");

        }
    }
}
