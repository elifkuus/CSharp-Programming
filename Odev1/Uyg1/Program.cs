using System;

namespace Uyg1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pozitif bir sayi giriniz: ");
            int n=int.Parse(Console.ReadLine());                     

            int[] cift=new int[n];
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Pozitif bir sayi giriniz: ");
                cift[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Cift Sayilar: ");
            foreach (var item in cift)
            {
                if (item%2==0)
                {
                    Console.Write(item+" ");
                }
            }
            

        }
    }
}
