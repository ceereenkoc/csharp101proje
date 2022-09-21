using System;

namespace datetimevemath
{
    class proje15
    {
        static void Main(string[] args)
        {
            //DateTime
            Console.WriteLine("##DateTime Kütüphanesi##");
            Console.WriteLine(DateTime.Now); 
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek); // Haftanın hangi günü olduğunu yazar.
            Console.WriteLine(DateTime.Now.DayOfYear); // Yılın kaçıncı günü olduğunu yazdırır.
        
            Console.WriteLine(DateTime.Now.ToLongDateString());  // Gün ve ayı string formatı ile getirir.
            Console.WriteLine(DateTime.Now.ToShortDateString()); 

            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());
       
            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));     
       
            //DateTime Formatları
            Console.WriteLine(DateTime.Now.ToString("dd")); //Integer karşılığı getirir.
            Console.WriteLine(DateTime.Now.ToString("ddd")); //String olarak 3 karakter getirir.
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Tam versiyonunu getirir.
            
            Console.WriteLine(DateTime.Now.ToString("MM")); // Integer karşılığını getirir.
            Console.WriteLine(DateTime.Now.ToString("MMM")); //String olarak 3 karakter getirir.
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //Tam versiyonunu getirir.

            Console.WriteLine(DateTime.Now.ToString("yy")); // Integer karşılığını getirir.
            Console.WriteLine(DateTime.Now.ToString("yyy")); //String olarak 3 karakter getirir.
            
            //Math Kütüphanesi
            Console.WriteLine("##Math Kütüphanesi##");

            Console.WriteLine(Math.Abs(-25)); //Mutlak değer
            
            Console.WriteLine(Math.Sin(30)); //Sinüs hesaplama
            Console.WriteLine(Math.Cos(30)); //Cosinüs hesaplama
            Console.WriteLine(Math.Tan(45)); //Tanjant hesaplama

            Console.WriteLine(Math.Ceiling(22.3)); //Kendisinden büyük en yakın tam sayıyı getirir.
            Console.WriteLine(Math.Round(22.3));  //Hangisine yakınsa o sayıyı getirir.
            Console.WriteLine(Math.Round(22.7));
            Console.WriteLine(Math.Floor(22.7));  //Kendisinden küçük en yakın tam sayıyı getirir.

            Console.WriteLine(Math.Max(2, 6));
            Console.WriteLine(Math.Min(2, 6));

            Console.WriteLine(Math.Pow(3,4)); // Üs alma işlemi yapar. (3^4)
            Console.WriteLine(Math.Sqrt(9)); // Karekök alır.
            Console.WriteLine(Math.Log(9)); // Logaritmik işlem yapar.
            Console.WriteLine(Math.Exp(3)); // e^sayı işlemini yapar. (e^3)
            Console.WriteLine(Math.Log10(10)); // Sayının logaritma 10 tabanındaki karşılığını verir.
                  

        }   
    }
}
