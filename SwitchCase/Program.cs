using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int month=DateTime.Now.Month;

            //Expression

            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak ayindasiniz!");
                    break;
                case 2:
                    Console.WriteLine("Subat ayindasiniz!");
                    break;
                case 3:
                    Console.WriteLine("Mart ayindasiniz!");
                    break;
                
                default:
                    Console.WriteLine("Yanlis veri girisi!");
                    break;

            }

            //3lu blok olarak yazdir
            switch (month)
            {  
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kis mevsimindesiniz!");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Bahar mevsimindesiniz!");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz mevsimindesiniz!");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar mevsimindesiniz!");
                    break;
                
                default:
                    break;
            }
        }
    }
}
