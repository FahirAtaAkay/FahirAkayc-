using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface ICreditManager
    {
        public void Calculate();

        public void DoSomething();
    }
}
//base class olarak oluşturmuştuk lakin buradaki metotlar her bir aynı inheritence daki class için farklı işlem yapmalı 
//bunun sebebi faklı kredilerin örneğin faklı faiz ve geri ödeme şartlarıyla verşlmesidir.
