using System;

namespace KupHacimHesaplama
{
    class Kup {
    
        public  double Hacim(int a)
        {
          
            return Math.Pow(a,3);
        }
        
    
    }


    class Program

    {
      
        static void Main(string[] args)
        {
            Kup kup = new Kup();
            Console.WriteLine("Bir sayi giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("küpün hacmi:" + kup.Hacim(sayi));

        }
    }
}
