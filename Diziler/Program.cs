using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
           //dizi tanimlama
           string[] renkler=new string[5];
           
           string[] hayvanlar={"kedi","kopek","kus","maymun"};

           int[] dizi;
           dizi=new int[5];

           //dizilere deger atama
           renkler[0]="mavi";
           dizi[3]=10;

           Console.WriteLine(hayvanlar[1]);
           Console.WriteLine(dizi[3]);
           Console.WriteLine(renkler[0]);

           //dongulerle dizi kullanimi

           Console.WriteLine("Dizi uzunlugu giriniz: ");
           int diziUzunlugu=int.Parse(Console.ReadLine());
           int[] sayiDizisi=new int[diziUzunlugu];

           for (int i = 0; i < diziUzunlugu; i++)
           {
               Console.Write("{0}. sayisini giriniz");
               sayiDizisi[i]=int.Parse(Console.ReadLine());
           }

           int toplam=0;
           foreach (var item in sayiDizisi)
           {
              toplam+=item;
           }
            Console.WriteLine("ortalama: "+toplam/diziUzunlugu);
        }
    }
}
