using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
           int a=3;
           int b=2;

           Console.WriteLine(a+b);

           int sonuc=Topla(a,b);
           Console.WriteLine(a+b);

            Metotlar ornek=new Metotlar();
            ornek.EkranaYazdir(sonuc.ToString());

            int sonuc2=ornek.ArttirVeTopla(ref a,ref b);
            ornek.EkranaYazdir(sonuc2.ToString());
            ornek.EkranaYazdir((a+b).ToString());
            

        }

        private static int Topla(int a, int b)
        {
            return (a+b);
        }
    }
    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
           Console.WriteLine(veri);
        }

        public int ArttirVeTopla(ref int a,ref int b)
        {
            a++;
            b++;
            return (a+b);
        }
    }
}
