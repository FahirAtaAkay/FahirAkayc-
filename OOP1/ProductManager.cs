using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
     class ProductManager
    {
        public void Add(Product product) 
        {
            // product.Name = "kamera";//product bir class olduğu için referans tiptir ve bellekteki adrese gider o yüzden kamera sonucunu aldık
            Console.WriteLine(product.Name+ " "+"eklendi");


        }
        public void Update(Product product) 
        {
            Console.WriteLine(product.Name+" "+"güncellendi");
        }
        public int Topla(int sayi1, int sayi2) 
        {
            return sayi1 + sayi2;
        }
        public void Topla2(int sayi1, int sayi2) 
        {
            Console.WriteLine(sayi1 + sayi2);
        }
        //void yalnızca istediğin işlemi yapar 
        //fakat sonucuyla ilgilenmez sadece ekrana yzar 
        //öte yandan public int olarak belirlediğimiz fonkiyon değeri döndürür ve tutar 
        //yani elde edilmiş gerçek ve fiziksel bir sonuç olur.


        }
    }

