using System;

namespace Uyg2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pozitif birinci sayiyi giriniz: ");
            int n=int.Parse(Console.ReadLine());   
            Console.WriteLine("Pozitif ikinci sayiyi giriniz: ");
            int m=int.Parse(Console.ReadLine());                 

            int[] dizi=new int[n];
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Pozitif bir sayi giriniz: ");
                dizi[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Girilen sayilardan m'ye esit veya tam bolunenler: ");
            foreach (var item in dizi)
            {
                if (m==item || item%m==0)
                {
                    Console.Write(item+" ");
                }
            }
        }
    }
}
