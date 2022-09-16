using System;

namespace proje2
{
    class Operatörler
    {
        static void Main(string[] args)
        {
            // Atama ve İşlemli Atama
            Console.WriteLine("Atamalar");

            int x = 3;
            int y = 3;
            y = y+2; // Normal arttırma ve atama
            Console.WriteLine(y);
           
            y += 2; // İşlemli atama
            Console.WriteLine(y);

            y /= 1;
            Console.WriteLine(y);

            x *= 2;
            Console.WriteLine(x);

            //Mantıksal Operatörler 
                // || --> veya
                // && --> ve
                // ! --> değil
            Console.WriteLine("Mantıksal Operatörler");
           
            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted) // Çalıştırmadı çünkü biri true diğeri ise false olduğu için şart sağlanmadı.
                Console.WriteLine("Perfect!");
            if(isSuccess || isCompleted)
                Console.WriteLine("Great!");
            if(isSuccess && !isCompleted)
                Console.WriteLine("Fine");

            // İlişkisel Operatörler
                // < (Küçüktür), <= (Küçük eşittir)
                // > (Büyüktür), >= (Büyük eşittir
                // == (Eşittir), != (Eşit değildir)

            Console.WriteLine("İlişkisel Operatörler");
            
            int a = 3;
            int b = 4;

            bool sonuç = a < b;
            Console.WriteLine(sonuç);
            sonuç = a > b;
            Console.WriteLine(sonuç);
            sonuç = a == b;
            Console.WriteLine(sonuç);
            sonuç = a != b; 
            Console.WriteLine(sonuç);
            sonuç = a <= b;
            Console.WriteLine(sonuç);
            sonuç = a >= b;
            Console.WriteLine(sonuç);
            
            // Aritmetik Operatörler
                // /, *, +, -
            Console.WriteLine("Aritmetik Operatörler");

            int s1 = 10;
            int s2 = 5;
            int sonuç1 = s1 / s2;
            Console.WriteLine(sonuç1);
            sonuç1 = s1 * s2;
            Console.WriteLine(sonuç1);
            sonuç1 = s1 + s2;
            Console.WriteLine(sonuç1);
            sonuç1 = s2 - s1;
            Console.WriteLine(sonuç1);
            sonuç1 = s1++;
            Console.WriteLine(s1);
            sonuç1 = s2--;
            Console.WriteLine(s2);

            // Mod alma operatörü (%) --> Kalanı bulmak için kullanılır.

            int sonuç2 = 20%3;
            Console.WriteLine(sonuç2);
            sonuç2 = 20%2;
            Console.WriteLine(sonuç2);

        }
    }
}