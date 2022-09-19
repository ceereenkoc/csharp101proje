using System;

namespace metotoverloading
{
    class proje12
    {
        static void Main(string[] args)
        {
            // Out Parametreler
            string sayı = "999";

            bool sonuç = int.TryParse(sayı, out int outSayı);
            if (sonuç)
            {
                Console.WriteLine("Başarılı.");
                Console.WriteLine(outSayı);
            }
            else
            {
                Console.WriteLine("Başarısız.");
            }
            
            Metotlar instance = new Metotlar();
            instance.Topla(4, 5, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            // Metot Overloading(Aşırı Yükleme)
                // Bir fonksiyonun imzasını değiştirerek birden farklı şekilde o fonksiyonun kullanılmasıdır.
            int ifade = 999;
            instance.EkranaYazdır(Convert.ToString(ifade));
            instance.EkranaYazdır(ifade);
            instance.EkranaYazdır("Ceren", "Koç");
            // Metot İmzası
            // metot_adı + parametre sayısı + parametre
        }        
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public void EkranaYazdır(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdır(int veri) //Overload edildi. Böylece bu metot hem strin hem int tipinde parametre alan karşılığı var.
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdır(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}

