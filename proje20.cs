using System;

namespace Sınıf2
{   
    class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi
            // class SınıfAdı
            //{
            //  [Erişim Belirleyici] [Veri Tipi] ÖzellikAdı;
            //  [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdı([Parametre Listesi])
            //   {
            //   Metot Komutları
            //   }
            //}
            
            //Erişim Belirleyiciler
            // * Public --> Her yerden erişilebilir.
            // * Private --> Sadece tanımlandığı sınıf içinde erişilebilir.
            // * Internal --> Sadece o proje içerisinde erişilebilir.
            // * Protected --> Sadece tanımlandığı sınıfta veya o sınıftan kalıtım alan programlarda kullanılır. 

            Console.WriteLine("Çalışan1'in Bilgileri");
            Çalışan çalışan1 = new Çalışan("Ayşe", "Kara", 23425634, "İnsan Kaynakları");
            çalışan1.ÇalışanBilgileri();

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
           
            Console.WriteLine("Çalışan2'nin Bilgileri");
            Çalışan çalışan2 = new Çalışan();
            çalışan2.Ad = "Deniz";
            çalışan2.Soyad = "Arda";
            çalışan2.No = 25646789;
            çalışan2.Departman = "Satın Alma";
            çalışan2.ÇalışanBilgileri();

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine("Çalışan1'in Bilgileri");
            Çalışan çalışan3 = new Çalışan("Ceren", "Koç");
            çalışan3.ÇalışanBilgileri();

        }
    }

    class Çalışan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Çalışan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        
        public Çalışan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            
        }

        public Çalışan(){}
        
        public void ÇalışanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı: {0}", Ad);
            Console.WriteLine("Çalışanın Soyadı: {0} ", Soyad);
            Console.WriteLine("Çalışanın Numarası: {0}", No);
            Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
        }
    }   
}