using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.TC + " TC'li " + musteri.Ad + " " + musteri.Soyad + " adlı kişi eklenmiştir.");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Listelenmiştir.");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.TC + " TC'li " + musteri.Ad + " " + musteri.Soyad + " adlı müşteri silinmiştir.");
        }

    }
}

