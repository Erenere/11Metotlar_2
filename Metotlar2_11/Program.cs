using System;

namespace Metotlar2_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi = "999";
            bool sonuc = int.TryParse(sayi, out int outSayi);

            if (sonuc)
            {
                Console.WriteLine("Basarili! ");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Basarisiz ");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4,5,out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            int ifade = 999;
            instance.EkranaYaz(Convert.ToString(ifade));
            instance.EkranaYaz(ifade);
            instance.EkranaYaz("AAA","BBBB");
            
        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public void EkranaYaz(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYaz(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYaz(string veri1, string veri2)
        {
            Console.WriteLine(veri1+veri2);
        }
    }
}