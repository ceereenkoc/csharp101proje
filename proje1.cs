using System;

namespace csharp101proje;

class proje1
{
    static void Main(string[] args)
    {
        Console.WriteLine("");

        byte b = 5; // 1 byte yer kaplar. 0-255 arasında değer alır.
        sbyte sb = 5; // 1 byte yer kaplar. -128 ile 127 arasında değer alır.

        short s = 5; // 2 byte yer kaplar.
        ushort us = 5; // 2 byte yer kaplar.

        Int16 i16 = 2; // 2 byte yer kaplar.
        Int32 i32 = 2; // 4 byte yer kaplar.
        Int64 i64 = 2; // 8 byte yer kaplar.

        int i = 2; // 4 byte yer kaplar.
        uint ui= 2; // 4 byte yer kaplar.

        long l = 2; // 8 byte yer kaplar.
        ulong ul = 2; // 8 byte yer kaplar.

        // Reel Sayılar için;

        float f = 2; // 4 byte yer kaplar.
        double d = 2; // 8 byte yer kaplar.
        decimal de = 2; // 16 byte yer kaplar.

        //Karakterler için;

        char c = '2'; // 2 byte yer kaplar. Tek karakter tanımlamak için uygundur.
        string str = "Ceren"; // Sınırsız

        //True/False;
        
        bool b1 = true;
        bool b2 = false;

        //DateTime

        DateTime dt = DateTime.Now;
        Console.WriteLine(dt);

        // Obje değerleri;

        object o1 = "x";
        object o2 = 'y';
        object o3 = 1 ;
        object o4 = 4.3;

        // string ifadeler;

        string str1 = string.Empty;
        str1 = "Ceren Koç";

        string ad = "Ceren";
        string soyad = "Koç";
        string tamAd = ad + " " + soyad;

        // integer ifadeler

        int integer1 = 5;
        int integer2 = 2;
        int integer3 =  integer1 * integer2;

        // boolean

        bool bool1 = 10 > 2;
        //Değişken Dönüşümleri;

        string str20 = "20";
        int int20 = 20;
        string yeniDeger = str20 + int20.ToString();
        Console.WriteLine(yeniDeger);

        int int21 = int20 + Convert.ToInt32(str20);
        Console.WriteLine(int21);

        int int22 = int20+int.Parse(str20);
    
        //String DateTime

        string datetime = DateTime.Now.ToString("dd.MM.yyyy");
        Console.WriteLine(datetime);

        string datetime1 = DateTime.Now.ToString("dd/MM/yyyy");
        Console.WriteLine(datetime1);
        
        //Saat
        string hour = DateTime.Now.ToString("HH:mm");
        Console.WriteLine(hour);
    }   
}