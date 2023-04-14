using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace MyDictionary 
{
    class Program 
    {
        static void Main(string[] args)
            
        {

            MyDictionary<int,string> postaKodu = new MyDictionary<int,string>();
            postaKodu.Add(35140, "karabağlar");
            postaKodu.Add(35030, "bornova");
            postaKodu.Add(35160, "yeşilyurt");
            postaKodu.Add(35210, "konak");
            postaKodu.Add(35280, "küçükyalı");

            Console.Write("posta kodu giriniz::");
            int girdi = Convert.ToInt32(Console.ReadLine());

            string ilce = postaKodu.search(girdi);

            if ( ilce != null ) 
            {
                Console.WriteLine(girdi+"posta kodu"+""+ilce+""+"ilçesine aittir");
                

            }
            else 
            {
                Console.WriteLine("HATALI PLAKA NUMARASI GİRDİNİZ");
            }
            Console.ReadKey();

            


            




        }
    }
}
