using System;

namespace Sınıf4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı:{0}", Çalışan.ÇalışanSayısı);

            Çalışan çalışan = new Çalışan("Ayşe", "Yılmaz", "İK");
            Console.WriteLine("Çalışan Sayısı:{0}", Çalışan.ÇalışanSayısı);
        
            Çalışan çalışan1 = new Çalışan("Deniz", "Arda", "İK");
            Çalışan çalışan2 = new Çalışan("Ceren", "Koç", "İK");
            Console.WriteLine("Çalışan Sayısı:{0}", Çalışan.ÇalışanSayısı);
        
            Console.WriteLine("Toplama işlemi sonucu: {0}", İşlemler.Topla(100,200));
            Console.WriteLine("Çıkarma işlemi sonucu: {0}", İşlemler.Çıkar(100,200));
        }   
    }

    class Çalışan
    {
        private static int çalışanSayısı;

        public static int ÇalışanSayısı { get => çalışanSayısı;}
    
        private string Isim;
        private string Soyisim;
        private string Departman;

        static Çalışan()
        {
            çalışanSayısı = 0;
        }

        public Çalışan(string ısim, string soyisim, string departman)
        {
            this.Isim = ısim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            çalışanSayısı++;
        } 
    }

    static class İşlemler
    {
        public static long Topla(int sayı1, int sayı2)
        {
            return sayı1 + sayı2;
        }
        public static long Çıkar(int sayı1, int sayı2)
        {
            return sayı1 - sayı2;
        }
    }
}