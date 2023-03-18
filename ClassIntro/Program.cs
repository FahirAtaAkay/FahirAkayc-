using System;

namespace ClassIntro
{

    class Program
    {
        static void Main(string[] args)
        {
            string adi = "fahir";
            int yasi = 21;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.KursunEgitmeni = "fahirakay";
            kurs1.IzlenmeOrani = 55;
            kurs1.YuzdeKacTamamlandi = 78;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "c++";
            kurs2.KursunEgitmeni = "marulkoç";
            kurs2.IzlenmeOrani = 24;
            kurs2.YuzdeKacTamamlandi = 78;



            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "java";
            kurs3.KursunEgitmeni = "senakoc";
            kurs3.IzlenmeOrani = 77;
            kurs3.YuzdeKacTamamlandi = 21;

            //Console.WriteLine(kurs1.KursAdi + ":" + kurs1.KursunEgitmeni +" " +"izlenme" + kurs1.IzlenmeOrani +  " " + " % " +kurs1.YuzdeKacTamamlandi);
            // Console.WriteLine(kurs2.KursAdi + ":" + kurs2.KursunEgitmeni +" " + "izlenme" +  kurs2.IzlenmeOrani + " " + "%" + kurs2.YuzdeKacTamamlandi);
            // Console.WriteLine(kurs3.KursAdi + ":" + kurs3.KursunEgitmeni +"" + "izlenme" + kurs3.IzlenmeOrani + " " + "%" + kurs3.YuzdeKacTamamlandi);


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, };

            foreach (var kurs in kurslar)
            {
                Console.Write(kurs.KursAdi + " " + kurs.KursunEgitmeni +" "+ "izleyen"+" "+ kurs.IzlenmeOrani + " " + "%" +kurs.YuzdeKacTamamlandi);
            }
            

            









        }
    }

    class Kurs

    {
        public string KursAdi { get; set; }

        public string KursunEgitmeni { get; set; }

        public int IzlenmeOrani { get; set; }


        public int YuzdeKacTamamlandi { get; set; }





    }
}