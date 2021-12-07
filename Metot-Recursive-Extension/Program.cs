using System;

namespace Metot_Recursive_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recursive - oz yinelemeli metotlar
           int result=1;
           for (int i = 1; i < 5; i++)
           {
               result*=3;

           }
           Console.WriteLine(result);

           Islemler instance=new();
           Console.WriteLine(instance.Expo(3,4));

           //Extension Metotlar
           string isim="Elif Kus";
           bool sonuc=isim.CheckSpaces();
           Console.WriteLine(sonuc);

           if (sonuc)
           {
               Console.WriteLine(isim.RemoveSpaces());
           }
           Console.WriteLine(isim.MakeUpperCase());
           Console.WriteLine(isim.MakeLowerCase());

           int[] dizi={9,3,6,2,1,5,0};
           dizi.SortArray();
           dizi.EkranaYaz();

           int sayi=5;
           Console.WriteLine(sayi.IsEverNumber());

           Console.WriteLine(isim.GetFirstCharacter());
        }
    }
    public class Islemler
    {
        public int Expo(int sayi,int us){
            if(us <2)
                return sayi;
            return Expo(sayi,us-1)* sayi;
        }
    }
    public static class Extension //nesnesiz erismek icin static olmali
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" "); //bosluk var mi kontrolu
        }

        public static string RemoveSpaces(this string param)
        {
            string[] dizi=param.Split(" ");
            return string.Join("",dizi);
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }
        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void EkranaYaz(this int[] param)
        {
            foreach(int item in param)
                Console.WriteLine(item);
        }
         public static bool IsEverNumber(this int param)
        {
            return param%2==0;
        }
         public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }
    }
    
}
