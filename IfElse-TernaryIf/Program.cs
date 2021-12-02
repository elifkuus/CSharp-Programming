using System;

namespace IfElse_TernaryIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int time=DateTime.Now.Hour;

            if (time >=6 && time<11)
                Console.WriteLine("Gunaydin!");
            else if (time <=10)
                Console.WriteLine("Iyi Gunler!");
            else
                Console.WriteLine("Iyi Geceler!");
            
            string sonuc=time<= 18 ? "Iyi Gunler!": "Iyi Geceler!";
            
            sonuc= time>=6 && time<11 ? "Gunaydin" : time <=18 ? "Iyi gunler" : "Iyi geceler";
            Console.WriteLine(sonuc);    
        }
    }
}
