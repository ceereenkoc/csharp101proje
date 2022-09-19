using System;

namespace metottanımlama
{
    class proje11
    {
        static void Main(string[] args)
        {
            //erisim_belirteci geri_donustipi metot_adi(parametreListesi/arguman)
            //{
                //Komutlar;
                //return;
            //}

            int a = 2;
            int b = 3;
            Console.WriteLine(a+b);
           
            int sonuç = Topla(a,b);
            Console.WriteLine(sonuç);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdır(Convert.ToString(sonuç));

            int sonuç2 = ornek.ArttırVeTopla(ref a, ref b);
            ornek.EkranaYazdır(Convert.ToString(sonuç2));
            ornek.EkranaYazdır(Convert.ToString(a+b));
        }

        static int Topla(int deger1, int deger2) // Erişilebilir olması için static bir metot oluşturduk.
        {
            return (deger1 + deger2);
        }
    }

    class Metotlar
    {
        public void EkranaYazdır(string veri) // Her yerden erişilebilir olması için public verilmelidir.
        {
            Console.WriteLine(veri);
        }

        public int ArttırVeTopla(ref int deger1, ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return(deger1+deger2);
        }
    }
}

// Referans vermek demek a ve b değerini vermek değil, bellekteki yerlerini vermek demek.
// Böylece kopyalar üzerinde çalışmak yerine orjina değişkenler üzerinde çalışıyor.