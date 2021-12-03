using System;

namespace While_ForeachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // While
            //1 den baslayarak konsoldan girilen sayiya kadar ort hesaplayip yazdir

            Console.WriteLine("Bir sayi giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            int sayac = 1;
            int toplam = 0;

            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayi);

            // a dan z ye kadar tum harfleri konsola yazdir
            char character = 'a';
            while (character <= 'z')
            {
                Console.Write(character);
                character++;
            }
            Console.WriteLine();
            
            Console.WriteLine("******* Foreach ********");
            string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
