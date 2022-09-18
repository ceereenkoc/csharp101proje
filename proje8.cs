using System;

namespace whileloop
{
    class proje8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#While#");
            // 1'den başlayarak console'dan girilen sayıya kadar(sayı dahil) ortalama hesaplayıp console yazdıran program
           
            Console.Write("Bir sayı giriniz:");
            int sayı = int.Parse(Console.ReadLine());
            int sayaç = 1;
            int toplam = 0;

            while (sayaç <= sayı)
            {
                toplam += sayaç;
                sayaç ++;
            }

            Console.WriteLine(toplam/sayı);

            // a'dan z'ye kadar olan tüm harfleri console yazdır.

            char karakter = 'a';

            while (karakter <= 'z')
            {
              Console.Write(karakter);
              karakter ++;  
            }

            Console.WriteLine("#ForEach#");
            
            string[] arabalar = {"BMW", "Ford", "Toyota", "Nissan"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
