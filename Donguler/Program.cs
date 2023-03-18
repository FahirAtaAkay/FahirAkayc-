using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args) 
        {


            //array - dizi

            string[] kurslar = new string[] {"yazılım geliştirici yetiştirme kursu","javakursu",
            "cart kursu", "curt kursu"};






            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("sayfa sonu");


            Console.WriteLine("for bitti");


            foreach (string kurs in kurslar) 
            {
                Console.WriteLine(kurs);
            } 
            
            //dizi temelli yapıaları tek tek dönmeye yarar bu kursları dolaş demek

        }
    }

}
