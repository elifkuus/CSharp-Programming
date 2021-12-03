using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ekrandan girilen sayiya kadar tek sayilari ekrana yazdir.
            Console.Write("Sayi giriniz: ");
            int sayi=int.Parse(Console.ReadLine());

            for (int i = 1; i <= sayi; i++)
            {
                if (i%2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            // 1 ile 1000 arasindaki tek ve cift sayilarin toplamini yazdir
            int tekToplam=0;
            int ciftToplam=0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i%2 == 0)
                {
                    ciftToplam=ciftToplam+i;
                }
                else
                {
                    tekToplam=tekToplam+i;                    
                }
            }

            Console.WriteLine("Tek Sayi Toplami: "+tekToplam);
            Console.WriteLine("Cift Sayi Toplami: "+ciftToplam);

            // break, continue komutu

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                    break;  //donguyu bitirir
                
                Console.WriteLine(i);                
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                    continue;   //4 u atlar devam eder
                               
                Console.WriteLine(i);                                
            }

        }
    }
}
