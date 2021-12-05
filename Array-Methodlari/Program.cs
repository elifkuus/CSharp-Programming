using System;

namespace Array_Methodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort -> kucukten buyuge diziyi siralar

            int[] sayiDizisi={23,12,4,86,72,3,11,17};

            Console.WriteLine("******** Sirasiz Dizi *********");
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("******** Sirali Dizi *********");
            Array.Sort(sayiDizisi);

            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            //Clear
            Console.WriteLine("******** Array Clear ********");
            //belirtilen indexten itibaren belirtilen sayi kadar siler
            Array.Clear(sayiDizisi,2,2);

            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            //Reverse
            Console.WriteLine("******** Array Reverse ********");
            //Diziyi ters cevir
            Array.Reverse(sayiDizisi);

            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            //IndexOf
            //verilen sayinin indexini dondurur yoksa -1
            Console.WriteLine("******** Array IndexOf *********");
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            //Resize
            Console.WriteLine("******** Array Resize *********");
            //Boyutunu 9 yapti
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8]=99;

            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            
            

        }
    }
}
