using System;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayi giriniz: ");
                int sayi=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girdiginiz sayi: "+sayi);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: "+ex.Message.ToString());               
            }

            try
            {
               //  int a=int.Parse(null);
                // int a=int.Parse("test");
                 int a=int.Parse("-2000000000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Bos deger girdiniz!");
                Console.WriteLine("Hata: "+ex.Message.ToString());

            }
            catch(FormatException ex){
                Console.WriteLine("Veri tipi uygun degil!");
                Console.WriteLine("Hata: "+ex.Message.ToString());
            }
            catch(OverflowException ex){
                Console.WriteLine("Cok kucuk ya da cok buyuk deger girdiniz!");
                Console.WriteLine("Hata: "+ex.Message.ToString());
            }
            finally{
                Console.WriteLine("Islem basariyla tamamlandi.");
            }
        }
    }
}
