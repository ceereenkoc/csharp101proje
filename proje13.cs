using System;

namespace rekürsifextension
{
    class proje13
    {
        static void Main(string[] args)
        {
            //Rekürsif(Öz yinelemeli) --> Kendi kendini çağıran fonksiyonlar.

            // 3^4'ün hesaplanması (for döngüsü)

            int sonuç = 1;
            for(int i = 1; i < 5; i++)
                sonuç = sonuç * 3;
            Console.WriteLine(sonuç);
            İşlemler instance = new();
            Console.WriteLine(instance.Expo(3, 4));

            // Extension 

            string ifade = "Ceren Koç";
            bool sonuç1 = ifade.CheckSpaces();
            Console.WriteLine(sonuç1);
            if(sonuç1)
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());
        
            int[] dizi = {9, 3, 6, 2, 1, 5, 0};
            dizi.SortArray();
            dizi.EkranaYazdır();

            int sayı = 5;
            Console.WriteLine(sayı.IsEvenNumber());
        
            Console.WriteLine(ifade.GetFirstCharacter());
        }
    }

    public class İşlemler
    {
        public int Expo(int sayı, int üs)
        {
            if(üs < 2)
                return sayı;
            return Expo(sayı, üs-1) * sayı;
        }
        // Expo (3, 4)
        // Expo (3, 3) * 3
        // Expo (3, 2) * 3 * 3
        // Expo (3, 1) * 3 * 3 * 3
        // 3 * 3 * 3 * 3 = 3 ^ 4
    }

    public static class Extension // static olmalı.
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("*", dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdır(this int[] param)
        {
            foreach (var item in param)
                Console.WriteLine(item);
        }

        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;
        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }
    }
}
