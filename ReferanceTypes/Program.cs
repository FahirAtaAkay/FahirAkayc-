using System;


namespace ReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 10;
            int sayi2 = 20;
            sayi = sayi2;
            sayi2 = 100;
            Console.WriteLine("sayı 1;" + sayi);
            int[] sayilar = new int[] { 1, 2, 3 };//101
            int[] sayilar2 = new int[] { 10, 20, 30 };//102
            sayilar = sayilar2;
            sayilar2[0] = 1000;
            Console.WriteLine(sayilar[0]);
            Person person1 = new Person();
            Person person2 = new Person();
            person1.Name = "Engin";
            person2 = person1;
            person1.Name = "arzu"; // adres eşitlendi
            Customer customer = new Customer();
            customer.Name = "salih";
            Employee employee = new Employee();

            Person person3 = customer;
            Console.WriteLine(((Customer)person3).CreditCardNumber);
            PersonManager personManager = new PersonManager();
            personManager.Add(person3);
            personManager.Add(customer);
            personManager.Add(employee);

        }
    }
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmploymentId { get; set; }
    }
    class PersonManager 
    {
        public void Add(Person person) //base class eklediğim için ister customer ister employee ile işlem yapabilirim
        {
            Console.WriteLine(person.Name);
        }
    }
}