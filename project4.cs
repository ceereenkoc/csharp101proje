using System;

namespace HataYönetimi
{
    class project4
    {
        static void Main(string[] args)
        {
            try //Hataya sebep olabilecek blok yazılır.
            {
                Console.WriteLine("Bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı: " + sayi);
            }
            catch(Exception ex) //Hata yakalandığı zaman ne yapılması isteniliyorsa o yazılır.
            {
                Console.WriteLine("Hata:" + ex.Message.ToString());
            }
            finally // Hata alsın almasın çalıştırılmasını istediğimiz başka bir kod bloğu için kullanılır. Kullanmak zorunda değilsin!
            {
                Console.WriteLine("İşlem tamamlandı.");
            }
            
            // Eğer kendimiz mesaj iletmek istiyorsak;
            try
            {
                // int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-123456789123");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz!");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil!");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz!");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem başarıyla tamamlandı.");
            }
        }
    }
}
