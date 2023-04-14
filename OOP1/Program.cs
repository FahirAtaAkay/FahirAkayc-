using System;

namespace OOP1 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "sandalye";
            product1.UnitPrice = 7500;
            product1.UnitsInStock = 10;

            Product product2 = new Product
            {
                Id = 2,
                UnitsInStock = 5,
                Name = "tabak",
                UnitPrice = 69,
            };
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            //int bool double değer sayının değerini fonksiyone yazar ve sayıyla bağlantıyı koparır
            //array class interface referans tip
            productManager.Topla2(3,6);

            //int toplamaSonucu = productManager.Topla(3, 6);

            //Console.WriteLine(toplamaSonucu*2);





        }
    }
}