using System;

namespace arraysınıfı
{
    class proje10
    {
        static void Main(string[] args)
        {
            //Sort Metodu
            Console.WriteLine("#Sort Metodu#");
            Console.WriteLine("#Sırasız Dizi#");
            int[] sayıDizisi = { 22, 12, 4, 86, 72, 3, 11, 17 };
            foreach (var sayı in sayıDizisi)
                Console.WriteLine(sayı);

            Console.WriteLine("#Sıralı Dizi#");
            Array.Sort(sayıDizisi);
            foreach (var sayı in sayıDizisi)
                Console.WriteLine(sayı);

            //Clear Metodu
            Console.WriteLine("#Clear Metodu#");

            Array.Clear(sayıDizisi, 2, 2); // 2. indeksten başlayarak 2 elemanı temizleyip yerine 0 yazar.
            foreach (var sayı in sayıDizisi)
                Console.WriteLine(sayı);

            //Reverse
            Console.WriteLine("#Reverse Metodu#");

            Array.Reverse(sayıDizisi); // Dizinin ortasını belirler ve ayna gibi tersine çevirir.
            foreach (var sayı in sayıDizisi)
            Console.WriteLine(sayı);

            //IndexOf
            Console.WriteLine("#Index Metodu#");

            Console.WriteLine(Array.IndexOf(sayıDizisi, 22)); // Dizinin verilen elemanın indeksini getirir. 
            Console.WriteLine(Array.IndexOf(sayıDizisi, 23)); // Eleman bulamazsa -1 döner.

            //Resize (Yeniden boyutlandırma)
            Console.WriteLine("#Resize Metodu#");

            Array.Resize<int>(ref sayıDizisi, 9);
            sayıDizisi[8] = 99;
            foreach (var sayı in sayıDizisi)
            Console.WriteLine(sayı);

        }
    }
}
