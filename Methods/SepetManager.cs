using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class SepetManager
    {
        public void Ekle(Product product) 
        {
            Console.WriteLine("sepete eklendi : " + product.Name);
        }

        public void Ekle2(string Name, string Description, int PriceTag, int stock)
         {
            Console.WriteLine(Name +"::" +Description+ PriceTag+stock+ "sepete başarıyla eklendi");
        }
    }
}
