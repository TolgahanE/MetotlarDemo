using System;

namespace MetotlarDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Tolgahan";
            musteri1.Soyad = "Erbabi";
            musteri1.yas = 24;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Burak";
            musteri2.Soyad = "Kaldırım";
            musteri2.yas = 26;

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            foreach (var musteri in musteriler)
            {
                musteriManager.Listele(musteri);
            }

            musteriManager.Sil(musteri2);
        }
    }
}
