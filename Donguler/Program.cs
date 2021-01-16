using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirme kursu";
            string kurs2 = "programlamaya başlamak içim temel kurs";
            string kurs3 = "Java Kursu";

            string[] kurslar= new string[] {

            "yazılım geliştirme kursu",
            "programlamaya başlamak içim temel kurs",
            "Java Kursu",
            "Pyton"
            };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("Sayfa Sonu");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa Sonu");
        }
    }
}
