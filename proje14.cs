using System;

namespace stringmetotlar
{
    class proje14
    {
        static void Main(string[] args)
        {
            string değişken = "Dersimiz C#, hoş geldiniz!";
            string değişken2 = "Merhaba!";

            //Length
            Console.WriteLine(değişken.Length);

            //ToUpper ve ToLower
            Console.WriteLine(değişken.ToUpper());
            Console.WriteLine(değişken.ToLower());
        
            //Concat
            Console.WriteLine(string.Concat(değişken, " Merhaba!"));
        
            //Compare ve CompareTo
            Console.WriteLine(değişken.CompareTo(değişken2)); // 1. değişken 2. değişkene eşit olursa 0 döndürür, daha büyükse 1 döndürür, eğer daha küçükse -1 döndürür.
            Console.WriteLine(string.Compare(değişken, değişken2, true)); // True dersek büyük küçük harf duyarsız durumuna gelir.
            Console.WriteLine(string.Compare(değişken, değişken2, false)); // False olursa büyük küçük harf duyarlıdır.
        
            //Contains
            Console.WriteLine(değişken.Contains(değişken2));
            Console.WriteLine(değişken.EndsWith("hoş geldiniz!"));
            Console.WriteLine(değişken.StartsWith("merhaba"));
            
            //IndexOf
            Console.WriteLine(değişken.IndexOf("C#")); // Eğer bulamasaydı -1 dönerdi.
            Console.WriteLine(değişken.IndexOf("-"));
            
            //LastIndexOf
            Console.WriteLine(değişken.LastIndexOf("i"));

            //Insert
            Console.WriteLine(değişken.Insert(0, "Merhaba! "));
            
            //PadLeft ve PadRight
            Console.WriteLine(değişken + değişken2.PadLeft(30)); //değişken2'in soluna 27'ye tamamlayacak kadar boşluk ekler.
            Console.WriteLine(değişken + değişken2.PadLeft(30,'*'));
            Console.WriteLine(değişken.PadRight(50) + değişken2); //değişken'in sağına 50'ye tamamlayacak kadar boşluk ekler.
            Console.WriteLine(değişken.PadRight(50,'*') + değişken2);
        
            //Remove
            Console.WriteLine(değişken.Remove(10)); //10. indexten başlayarak sonuna kadar siler.
            Console.WriteLine(değişken.Remove(5, 3)); //5. indexten başlayarak üç karakter siler.
            Console.WriteLine(değişken.Remove(0,1)); //En baştaki karakteri siler.
        
            //Replace
            Console.WriteLine(değişken.Replace("C#", "CSharp"));
            Console.WriteLine(değişken.Replace(" ", "*"));
        
            //Split
            Console.WriteLine(değişken.Split(' ')[1]);
        
            //Substring
            Console.WriteLine(değişken.Substring(4)); // 4. indexten başlar sonuna kadar getirir.
            Console.WriteLine(değişken.Substring(4,6)); // 4. indexten başlar 6 karakter getirir.
        }   
    }
}
