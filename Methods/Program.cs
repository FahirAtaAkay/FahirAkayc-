using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "kulaklık";

            int urunFiyati = 1500;

            string aciklama = "JBL TUNE 500BT";

            Product product1 = new Product();

            product1.Name = "kulaklık";
            product1.PriceTag = 1500;
            product1.Description = "JBL TUNE 500BT";



            Product product2 = new Product();

            product2.Name = "Tablet Bilgisayar";
            product2.PriceTag = 16000;
            product2.Description = "Lenovo Thinkpad cartcurt";

            Product[] products = { product1, product2 };

            foreach (Product product in products) 
            {
                Console.WriteLine(product.Name + " " +  product.PriceTag + " " + product.Description);
            }

            Console.WriteLine("-----methods----");


            //instance (class example is being made)
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
            sepetManager.Ekle2("tablet bilgisayar", "Lenovo thinkpad cc", 7800,10);
            sepetManager.Ekle2("tablet bilgisayar", "Lenovo thinkpad cc", 7800,21);
            sepetManager.Ekle2("tablet bilgisayar", "Lenovo thinkpad cc", 7800,135);
            sepetManager.Ekle2("tablet bilgisayar", "Lenovo thinkpad cc", 7800,45);

            



            //var- variable arraydeki veri tipini otomatik yakaladığı için
            //for ve foreach var ile de çalışıyor

        }
    }   

}