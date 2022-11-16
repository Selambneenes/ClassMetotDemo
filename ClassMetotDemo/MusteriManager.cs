using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.AdiSoyadi+ "Başarıyla eklendi.");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Musteri Id : " + musteri.Id);
            Console.WriteLine("Musteri Tc : " + musteri.Tc);
            Console.WriteLine("Müşteri Adı Soyadı : " + musteri.AdiSoyadi);
            Console.WriteLine("Müşteri Yaşı : " + musteri.Yasi);
            Console.WriteLine("Musteri Şehri : " + musteri.Sehir);
            Console.WriteLine("Müşteri Mesleği : " + musteri.Meslek);
            Console.WriteLine("Müşteri Maaşı : " + musteri.Maas);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.AdiSoyadi + "Başarıyla Silindi");
        }
    }
}
