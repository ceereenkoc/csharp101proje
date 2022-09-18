using System;

namespace Diziler
{
    class proje9
    {
        static void Main(string[] args)
        {
            //Dizi Tanımlama

            string[] renkler = new string[5]; //Dizinin boyutu belli fakat elemanları belli değil.

            string[] hayvanlar = {"Kedi", "Köpek", "Kuş", "Maymun"}; // Dizinin elemanları ve boyutu belli.

            int[] dizi; //Eleman sayısını sonradan tanımlayabiliriz.
            dizi = new int[5];

            //Dizilere Değer Atama ve Erişim

            renkler[0] = "Mavi"; // Renkler dizisinin ilk elamanına maviyi atadım.
            Console.WriteLine(renkler[0]);

            Console.WriteLine(hayvanlar[0]); // Hayvanlar dizisinin ilk elamanını getirir.

            dizi[3] = 10; // 15. satırda oluşturduğum dizinin 4. elamanına 10 değerini atadık.
            Console.WriteLine(dizi[3]);

            //Döngülerle Dizi Kullanımı
            // Klavyeden girilen n tane sayının ortalamasını alan program.

            Console.WriteLine("Dizinin eleman sayısını giriniz:");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayıDizisi =  new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("{0}. sayıyı giriniz:", i+1);
                sayıDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayı in sayıDizisi)
                toplam += sayı;

            Console.Write("Ortalamam: " + toplam/diziUzunlugu);

        }
    }
}
