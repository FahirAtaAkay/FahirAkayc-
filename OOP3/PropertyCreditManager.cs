using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class PropertyCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("KONUT KREDİSİ HESAPLANDI");
        }

        public void DoSomething()
        {
            Console.WriteLine("ihtiyac kredisi odeme planı hesaplandı");
        }
    }
}
