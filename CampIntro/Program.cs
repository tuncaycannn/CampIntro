using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string categoryTag = "Kategori";
            int ogrenciSayisi = 32000000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun= 7.35;
            double dolarBugun= 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }


            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("sisteme giriş yapıldı");
            }
            else
            {
                Console.WriteLine("Başarısız...");
            }


            Console.WriteLine(categoryTag);
        
        }
    }
}
