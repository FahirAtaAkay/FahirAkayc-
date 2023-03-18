using System;

namespace Fahirakay
    {


    class Program
    {


        static void Main(string[] args)
        {
            string KategoriEtiketi = "kategori";
            int musteriSayisi = 1500; //int tam sayıları tutar sinirlanmistir
            double faizOrani = 1.55;
            bool sistemeGirisYapmismi = true;
            double dolarDun = 7.35;
            double dolarBugün = 7.55;

            if (dolarDun > dolarBugün)
            {
                Console.WriteLine("azaldı!!");

            }
            else if(dolarDun < dolarBugün)
            {
                Console.WriteLine("arttı!!");
            }
            else
            {
                Console.WriteLine("değişmedi!!");
            }
            if (sistemeGirisYapmismi == true)
              
            {
                Console.WriteLine("Kullanici Ayarlari Butonu");

            }
            else
            {
                Console.WriteLine("giris yap butonu");
            }

            

            
            

      


            Console.WriteLine(KategoriEtiketi);
            Console.WriteLine(KategoriEtiketi);
            Console.WriteLine(KategoriEtiketi);
            Console.WriteLine(KategoriEtiketi);

        }
    }

    

        


    

     

   
    








}