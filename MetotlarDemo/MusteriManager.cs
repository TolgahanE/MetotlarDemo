using System;
using System.Collections.Generic;
using System.Text;

namespace MetotlarDemo
{
    class MusteriManager
    {

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri Eklendi : \n" + musteri.Ad + "\n" + musteri.Soyad + "\n" + musteri.yas + "\n");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Musteri Silindi : \n" + musteri.Ad + "\n" + musteri.Soyad + "\n" + musteri.yas + "\n");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Musteri Listelendi : \n" + musteri.Ad + "\n" + musteri.Soyad + "\n" + musteri.yas + "\n");
        }

    }
}
