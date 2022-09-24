using System;

namespace Sınıf5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdörtgen dikdörtgen = new Dikdörtgen();
            dikdörtgen.kısaKenar = 3;
            dikdörtgen.uzunKenar = 4;
            Console.WriteLine(" Class Alan Hesabı: {0}", dikdörtgen.AlanHesapla());

            //Struct Yapısı-1
            //Dikdörtgen_Struct dikdörtgen_struct = new Dikdörtgen_Struct();
            //dikdörtgen_struct.kısaKenar = 3;
            //dikdörtgen_struct.uzunKenar = 4;
            //Console.WriteLine("Struct Alan Hesabı: {0}", dikdörtgen_struct.AlanHesapla());

            //Struct Yapısı-2
            //Dikdörtgen_Struct dikdörtgen_struct;
            //dikdörtgen_struct.kısaKenar = 3;
            //dikdörtgen_struct.uzunKenar = 4;
            //Console.WriteLine("Struct Alan Hesabı: {0}", dikdörtgen_struct.AlanHesapla());

            Dikdörtgen_Struct dikdörtgen_struct = new Dikdörtgen_Struct(3,4);
            Console.WriteLine("Struct Alan Hesabı: {0}", dikdörtgen_struct.AlanHesapla());
        
            
        }   
    }
    class Dikdörtgen
    {
        public int kısaKenar;
        public int uzunKenar;
        public Dikdörtgen()
        {
            kısaKenar = 3;
            uzunKenar = 4;
        }
        public long AlanHesapla()
        {
            return this.kısaKenar * this.uzunKenar;
        }
    }
    struct Dikdörtgen_Struct
    {
        public int kısaKenar;
        public int uzunKenar;
        public Dikdörtgen_Struct(int kısaKenar, int uzunKenar)
        {
            this.kısaKenar = kısaKenar;
            this.uzunKenar = uzunKenar;
        }
        public long AlanHesapla()
        {
            return this.kısaKenar * this.uzunKenar;
        }
    }
}
