using System;

namespace generickoleksiyon
{
    class proje16
    {
        static void Main(string[] args)
        {
            // List <T> class
            // System.Collection.Generic
            // T --> Object türündedir. Nesnelerin tipini ifade eder

            List<int> sayıListesi = new List<int>();

            sayıListesi.Add(23);
            sayıListesi.Add(10);
            sayıListesi.Add(4);
            sayıListesi.Add(5);
            sayıListesi.Add(92);
            sayıListesi.Add(34);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(sayıListesi.Count);
            Console.WriteLine(renkListesi.Count);

            //Forecah ve List.Foreach ile elemanlara erişim
            foreach (var sayı in sayıListesi)
                Console.WriteLine(sayı);                
            
            foreach (var renk in renkListesi)
                Console.WriteLine(renk);                
            
            sayıListesi.ForEach(sayı => Console.WriteLine(sayı));
            renkListesi.ForEach(renk => Console.WriteLine(renk));
        
            //Listeden eleman çıkarma
            sayıListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayıListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayıListesi.ForEach(sayı => Console.WriteLine(sayı));
            renkListesi.ForEach(renk => Console.WriteLine(renk));
        
            //Liste içerisinde arama
            if(sayıListesi.Contains(10))
                Console.WriteLine("10 liste içerisinde bulundu.");
            
            // Eleman ile index'eerişme
            Console.WriteLine(renkListesi.BinarySearch("Turuncu"));

            //Diziyi List'e çevirme
            string[] hayvanlar = {"Kedi", "Köpek", "Kuş"};
        
            List<string> hayvanListesi = new List<string>(hayvanlar);
        
            //Liste temizleme
            hayvanListesi.Clear();

            //List içerisinde nesne tutma
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
            
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Ayşe";
            kullanıcı1.Soyisim = "Yılmaz";
            kullanıcı1.Yaş = 26;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "Özcan";
            kullanıcı2.Soyisim = "Çalışkan";
            kullanıcı2.Yaş = 26;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe  = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar(){
                Isim = "Deniz",
                Soyisim = "Arda",
                Yaş = 24
                });

            foreach (Kullanıcılar kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı Adı: " + kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soyadı: " + kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı Yaşı: " + kullanıcı.Yaş);
            }

            yeniListe.Clear();
        }
    } 

    public class Kullanıcılar
    {
        private string isim;
        private string soyisim;
        private int yaş;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yaş { get => yaş; set => yaş = value; }
    }  
}

