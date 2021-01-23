using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri client1 = new Musteri();
            client1.TC = 12345678901;
            client1.Ad = "Sergen";
            client1.Soyad = "Yalçın";

            Musteri client2 = new Musteri();
            client2.TC = 34343433111;
            client2.Ad = "İlhan";
            client2.Soyad = "Mansız";

            Musteri client3 = new Musteri();
            client3.TC = 55445432321;
            client3.Ad = "Atilla";
            client3.Soyad = "Yeşilada";

            

            Console.WriteLine("Listelenmek istenen müşteriler");
            Musteri[] musteriler = new Musteri[] { client1, client2, client3 };

            foreach (var Musteri in musteriler)
            {
                Console.WriteLine(Musteri.TC + " " + Musteri.Ad + " " + Musteri.Soyad);
            }


            Console.WriteLine("Eklenmek istenen müşteriler");
            MusteriManager musteri = new MusteriManager();
            musteri.Ekle(client1);
            musteri.Ekle(client2);
            musteri.Ekle(client3);



            Console.WriteLine("Silinmek istenen müşteriler");
            musteri.Sil(client3);

            Console.WriteLine("Güncellenmek istenen müşteriler");
            

        }
    }
}