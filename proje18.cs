using System;

namespace dictionary
{
    class proje18
    {
        static void Main(string[] args)
        {
            //system.collection.generic
            Dictionary<int,string> kullanıcılar = new Dictionary<int, string>();

            kullanıcılar.Add(10, "AyşeYılmaz");
            kullanıcılar.Add(12, "Ahmet Yılmaz");
            kullanıcılar.Add(18, "Deniz Arda");
            kullanıcılar.Add(20, "Özcan Coşar");

            //Dizinin Elemanlarına Erişim
            Console.WriteLine("---ElemanlaraErişim---");

            Console.WriteLine(kullanıcılar[12]);
            foreach (var item in kullanıcılar)
                Console.WriteLine(item);              
            
            //Count
            Console.WriteLine("---Count---");
            Console.WriteLine(kullanıcılar.Count());

            //Contains
            Console.WriteLine("---Contains---");
            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("Ceren Koç"));
        
            //Remove
            Console.WriteLine("---Remove---");
            kullanıcılar.Remove(12);
            foreach (var item in kullanıcılar)
                Console.WriteLine(item);  
            
            //Keys
            Console.WriteLine("---Keys---");
            foreach (var item in kullanıcılar.Keys)
                Console.WriteLine(item);  
            //Values
            Console.WriteLine("---Values---");
            foreach (var item in kullanıcılar.Values)
                Console.WriteLine(item);  
        }
    }
}
