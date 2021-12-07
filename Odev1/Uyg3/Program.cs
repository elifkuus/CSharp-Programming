using System;

namespace Uyg3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pozitif birinci sayiyi giriniz: ");
            int n=int.Parse(Console.ReadLine());                    

            string[] dizi=new string[n];
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Kelime giriniz: ");
                dizi[i]=Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine("Girilen kelimelerin sondan basa listesi: ");
            for (int i = n-1; i >= 0; i--)
            {
               Console.Write(dizi[i]+" ");
            }
        }
    }
}
