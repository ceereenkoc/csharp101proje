using System;

namespace Sınıf3
{
    class Program
    {
        static void Main(string[] args)
        {
            Öğrenci öğrenci = new Öğrenci();
            öğrenci.Isim = "Ayşe";
            öğrenci.Soyisim = "Yılmaz";
            öğrenci.ÖğrenciNo = 293;
            öğrenci.Sınıf = 3;

            öğrenci.SınıfAtlat();
            öğrenci.ÖğrenciBilgileriniGetir();

            Öğrenci öğrenci1 = new Öğrenci("Deniz", "Arda", 256, 1);
            öğrenci1.SınıfDüşür();
            öğrenci1.SınıfDüşür();
            öğrenci1.ÖğrenciBilgileriniGetir();
        }
    }
    
    class Öğrenci
    {
        private string isim;
        private string soyisim;
        private int öğrenciNo;
        private int sınıf;

        public string Isim 
        { 
            get {return isim;}
            set {isim = value;} 
        }

        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int ÖğrenciNo { get => öğrenciNo; set => öğrenciNo = value; }
        public int Sınıf 
        { 
            get => sınıf; 
            set
            {
                if(value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir.");
                    sınıf = 1;
                }
                else
                    sınıf = value;
            } 
        }

        public Öğrenci(string ısim, string soyisim = null, int öğrenciNo = 0, int sınıf = 0)
        {
            Isim = ısim;
            Soyisim = soyisim;
            ÖğrenciNo = öğrenciNo;
            Sınıf = sınıf;
        }

        public Öğrenci(){}

        public void ÖğrenciBilgileriniGetir()
        {
            Console.WriteLine("****ÖğrenciBilgileri****");
            Console.WriteLine("Öğrencinin Adı:      {0}", this.Isim);
            Console.WriteLine("Öğrencinin Soyadı:   {0}", this.Soyisim);
            Console.WriteLine("Öğrencinin Numarası: {0}", this.ÖğrenciNo);
            Console.WriteLine("Öğrencinin Sınıfı:   {0}", this.Sınıf);
        }

        public void SınıfAtlat()
        {
            this.Sınıf = this.Sınıf + 1;
        }

        public void SınıfDüşür()
        {
            this.Sınıf = this.Sınıf - 1;
        }
    }
}
