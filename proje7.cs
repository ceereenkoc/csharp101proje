using System;

namespace forloop
{
    class proje7
    {
        static void Main(string[] args)
        {
            // 1'den başlayarak ekrandan girilen sayıya kadar tek olan sayıları yazdıran program.
            Console.Write("Bir sayı giriniz:");
            int sayaç = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayaç ; i++) // i 0'dan başlayarak her döngü içerisinde bir arttırarak length'ten küçük olana kadar bu for döngüsü dönecek.
            {
                if(i % 2 == 1)
                    Console.WriteLine(i);
            }

            // 1 ile 1000 arasındaki tek ve çift sayıları toplayıp console yazdıran program
            int tekToplam = 0;
            int çiftToplam= 0;
            for (int i = 1; i <= 1000; i++)
            {
                if(i % 2 == 1)
                    tekToplam += i; // tekToplam = tekToplam + i;
                else
                    çiftToplam += i; // çiftToplam = çifToplam + i;
            }     
            Console.WriteLine("Tek Toplam: " + tekToplam);
            Console.WriteLine("Çift Toplam: " + çiftToplam);
       
            // break ve continue terimleri
            // Eğer bir döngü içinde bir case bağlı olarak döngüyü sonlandırmak istiyorsak break kullanılır.
            // Eğer bir şarta bağlı olarak mevcut döngünün o cycle'ını atlamak istiyorsak continue kullanılır. 

            for (int i = 1; i < 10; i++) // 1'den başladı 10'a kadar gidecekti ama koşul sağlanınca döngü sonlandı.
            {
                if(i == 4)
                    break;
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++) // 1'den başladı 10'a kadar gitti fakat koşulun sağlandığı kısmı atladı ve döngüye devam etti sonlandırdı.
            {
                if(i == 4)
                    continue;
                Console.WriteLine(i);
            }

            // break o an içinde olduğu durumu sonlandırır. 
            // Eğer içiçe loop varsa iç içe break ifadesi kullanılmışsa tüm loop sonlanmaz,
            // orası devam eder ve en iç loop sonlanır.

        }
    }
}
