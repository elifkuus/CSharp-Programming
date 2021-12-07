using System;

namespace Uyg4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cumle yaziniz: ");
            string n=Convert.ToString(Console.ReadLine());     
           
            Console.WriteLine("Toplam kelime sayisi: "+n.WordCount());
            Console.WriteLine("Toplam harf sayisi: "+n.LetterCount());              


        }
    }
    public static class Extension
    {
        public static int WordCount(this string param)
        {
            string[] dizi=param.Split(" ");
            return dizi.Length;
        }
        public static int LetterCount(this string param)
        {
            string liste =  "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ"
                           +"abcçdefgğhiıjklmnoöprsştuüvyz";
            int sayac=0;
            for (int i = 0; i < param.Length; i++)
            {
               if (liste.Contains(param[i]))
               {
                   sayac++;
               }
            }
            return sayac;

        }
    }
}
