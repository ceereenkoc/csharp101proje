using System;

namespace Sınıf1
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
        
            Çalışan çalışan1 = new Çalışan();
            çalışan1.Ad = "Ayşe";
            çalışan1.Soyad = "Kara";
            çalışan1.no = 23425634;
            çalışan1.Departman = "İnsan Kaynakları";
            çalışan1.ÇalışanBilgileri();

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
           
            Çalışan çalışan2 = new Çalışan();
            çalışan2.Ad = "Deniz";
            çalışan2.Soyad = "Arda";
            çalışan2.no = 25646789;
            çalışan2.Departman = "Satın Alma";
            çalışan2.ÇalışanBilgileri();
        }
    }

    class Çalışan
    {
        public string Ad;
        public string Soyad;
        public int no;
        public string Departman;
        
        public void ÇalışanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı: {0}", Ad);
            Console.WriteLine("Çalışanın Soyadı: {0} ", Soyad);
            Console.WriteLine("Çalışanın Numarası: {0}", no);
            Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
        }
    }   
}
