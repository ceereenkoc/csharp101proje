using System;

namespace Sınıf6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Günler.Pazar);
            Console.WriteLine((int)Günler.Cumartesi);

            int sıcaklık = 32;
            if(sıcaklık <= (int)HavaDurumu.Normal)
                Console.WriteLine("Dışarıya çıkmak için havanın ısınmasını bekle.");
            else if(sıcaklık >= (int)HavaDurumu.Sıcak)
                Console.WriteLine("Dışarıya çıkmak için sıcak bir gün.");
            else if(sıcaklık >= (int)HavaDurumu.Normal && sıcaklık < (int)HavaDurumu.ÇokSıcak)
                Console.WriteLine("Hadi dışarıya çıkalım.");
        }
    }

    enum Günler //Numeric olan veriyi anlamlı bir şekilde tutar. Ardışık olarak değer takip eder.
    {
        Pazartesi = 1,
        Salı,   
        Çarşamba,
        Perşembe,
        Cuma = 23,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soğuk = 5,
        Normal = 20,
        Sıcak = 25,
        ÇokSıcak = 30
    }
}
