
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
     class ApplicationManager
    {
        public void Applicate(ICreditManager creditManager) 
        {
            //Basvuran bilgileri
            //
            //
            creditManager.Calculate();
            // artık tüm referansları interfaceden alan ve hangi krediyi yollarsak onun koşullarını çalıştıran 
            //bir sistem kurmuş olduk
        }
        
        public void CreditInformation(List<ICreditManager> credits) 
        {
            foreach (var credit in credits) 
            {
                credit.Calculate();
            }

        }
    }
}
