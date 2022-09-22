using System;
using System.Collections;

namespace arraylist
{
    class proje17
    {
        
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();

            // liste.Add("Ayşe");
            //liste.Add(2);
            //liste.Add(true);
            //liste.Add('a');

            //İçerisinden elemanlara erişme
            //Console.WriteLine(liste[1]);
            //foreach (var item in liste)
            //    Console.WriteLine(item);

            //AddRange (Birden fazla toplu elaman yazdırır.)
            Console.WriteLine("---AddRange---");
            
            //string[] renkler = {"Kırmızı", "Sarı", "Yeşil" };
            List<int> sayılar = new List<int>(){1, 8, 3, 7, 9, 92, 5};
            //liste.AddRange(renkler);
            liste.AddRange(sayılar);

            foreach (var item in liste)
                Console.WriteLine(item);

            //Sıralama(sort)
            Console.WriteLine("---Sort---");

            liste.Sort(); 
            foreach (var item in liste)
                Console.WriteLine(item);

            //BinarySearch
            Console.WriteLine("---BinarySearch---");
            Console.WriteLine(liste.BinarySearch(9));

            //Reverse
            Console.WriteLine("---Reverse---");
            
            liste.Reverse();
            foreach (var item in liste)
                Console.WriteLine(item);

            //Clear
            Console.WriteLine("---Clear---");
            liste.Clear();
            foreach (var item in liste)
                Console.WriteLine(item);
        }
    }
}