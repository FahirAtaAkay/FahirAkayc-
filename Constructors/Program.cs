using System;

namespace Constructors 
{
    class Program 
    
    {
        public static void Main(string[] args) 
        
        {
            Customer customer = new Customer { Id = 1, Name = "engin", Address = "ankara" };
            Customer customer1 = new Customer { Id = 2, Name = "fahir", Address = "eskişehir" };
            Customer customer2 = new Customer(2, "ali", "velioğlu", "ankara");
            Console.WriteLine( customer2.Name);



        }

    }
    class Customer 
    {    //default constructor
        public Customer()//2 constructor yazdık ki farklı kullanımlarda farklı constructorları çalıştırarak errorları engelledik
        {
            
        }
        public Customer(int id,string name,string surname,string address)
        {
            Console.WriteLine("yapıcı blok çalıştı");

            Id = id;
            Name = name;
           Surname = surname;
            Address = address;


        }
        public int Id { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Address { get; set; } 
    }
}
