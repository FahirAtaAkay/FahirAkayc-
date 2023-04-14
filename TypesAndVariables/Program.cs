using System;


namespace TypesAndVariables 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("helloworld");
            Console.ReadLine();
            double number7 = 10.4;
            decimal number8 = // daha fazla decimal tutan ondalıklı
                
            char character = 'A'; // stringler karakter dizileridir denebilir
            bool condition = false;// doğru veya yanlısı mantıksaş yorumlar
            byte number4 = 255; //0-255
            short number3 = 5; // +- 32767 sınır var
            int number1 = 10;
            var number14 = 11;
            long number2 = 1000000000000; //longda daha çok decimal yazılabilir lakin bellekte iki katı yer kaplar   
            Console.WriteLine("Number1 is {0}", number1); // virgülden sonraki değerin kaçıncı değerse onu yazdiye  belirttik
            Console.WriteLine("character is : {0}", (int) character);
        }



        enum Days // eger cw days. friday yazarsam friday der basına(int) koyarsak kaçıncı olduğunu sayısal olarak yazar,default değer atama imkanımız vardır 
        {
            Monday, Tuesday, wednesday, thursday, friday,
        }
        
        //longun sınırı 19 karakterli intin sınırı iki milyar 147 milyonundan biraz fazladır

    }
}
