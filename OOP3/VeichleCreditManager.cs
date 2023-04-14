using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class VeichleCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("TASIT KREDİSİ YÜZDELERİ HESAPLANDI");
        }

        public void DoSomething()
        {
            Console.WriteLine("tasıt kredisi ödemesi hesaplandı");
        }
    }
}
