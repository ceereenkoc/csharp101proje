using System;

namespace TipDönüşümleri
{
    class proje3
    {
        static void Main(string[] args)
        {
            // Implicit Conversion (Bilinçsiz/Kapalı Dönüşüm) --> Çevirmeyi makne yapar.
            
            Console.WriteLine("#Implicit#");

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d =  a + b + c; //Kapasite eşitsizliği olsaydı, d daha küçük olsaydı bu işlem yapılamazdı.
            Console.WriteLine("d: " + d);

            long h = d;
            Console.WriteLine("h: " + h);

            float i = h;
            Console.WriteLine("i: " + i);

            string e = "Ceren";
            char f = 'k';
            object g =  e + f + b; // object tipinde yazdıklarımızın hepsi birleşebilir.
            Console.WriteLine("g: " + g);

            // Explicit Dönüşüm (Bilinçli/Açık Dönüşüm) --> Makine kendi kendine bu dönüşümleri yapamaz.
            
            Console.WriteLine("#Explicit#");

            int x  = 4;
            byte y = (byte)x;
            Console.WriteLine("y= " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t= " + t);

            float w = 10.3f;
            byte v = (byte)w; // 10.3'ü byte çevirirken yuvarlayıp 10 yapıyor.
            Console.WriteLine("v= " + v);

            // ToString Metodu
            Console.WriteLine("#ToString Metodu#");

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy= " + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz= " + zz);

            //System.Convert Sınıfı
            Console.WriteLine("#System.Convert Sınıfı#");

            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam= " + toplam);

            //Parse Metodu
            Console.WriteLine("#Parse Metodu#");
            ParseMetod();
        }
        public static void ParseMetod()
        {
            string metin1 = "10";
            string metin2 = "10.25";

            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            Console.WriteLine("rakam1= " + rakam1);

            double1 = Double.Parse(metin2);
            Console.WriteLine("double1= " + double1);
        }
    }
}