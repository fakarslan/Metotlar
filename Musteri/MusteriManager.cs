using System;
using System.Collections.Generic;
using System.Text;

namespace Musteri
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " adlı müşteri " + musteri.Id + " numarası ile sisteme eklendi.");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " - " + musteri.Id);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " numaralı " + musteri.Adi + " " + musteri.Soyadi + " adlı müşteri sistemden silindi.");
        }

    }
}
