using System;

namespace Musteri
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Hale";
            musteri1.Soyadi = "Odabaşı";
            musteri1.Id = 92345654;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Furkan";
            musteri2.Soyadi = "Akarslan";
            musteri2.Id = 87665456;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Zeyd";
            musteri3.Soyadi = "Tunca";
            musteri3.Id = 73456543;

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Console.WriteLine("---------------------");

            Console.WriteLine("MÜŞTERİ LİSTESİ");
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);

            Console.WriteLine("---------------------");

            musteriManager.Sil(musteri3);
        }
    }
}
