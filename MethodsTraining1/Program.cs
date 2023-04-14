using System;

namespace MethodsTraining1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Add();
            //Add();
            //var result = Add2();
            //int number1 = 34;
            //int number2 = 100;
            //var result2 = Add3(ref number1, number2);
            //Console.WriteLine(result);
            //var result = Add2(11, 12); //değişkenlere default değer atamak için 
            //Console.WriteLine(result); // add methodunun içine veri yazarken = değer yaparak
            //       Console.ReadLine();// değişkene sonradan bir değer verilmezse kabul edilecek değer göstermiş olunur
            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(3,5,7)); // metodu aynı isimle verdim çünkü program bunu tanıdı ve aynı işlemin aynı tip verilerle yapııldığını anladı burası önemli
            Console.WriteLine(Add4(1,2,3,4,5,6,7,8,9));//params sayesinde metoda aynı tipte istediğimiz kadar parametre gönderebiliriz
        }

        static void Add()
        {
            Console.WriteLine("Added!!");

        }

        static int Add2(int number1 = 250, int number2 = 529) // add2 hiçbir parametre vermezsek çalışır METHODLARIN EN SONUNDA OLMAK ZORUNDA
        {

            return number1 + number2; //or var result = number1 + number2 sonrasında return

        }
        static int Add3(ref int number1, int number2) //number1 i referanslayarak değer tipini değil de referansını kullanmış olduk
        {
            number1 = 30;
            return number1 + number2;// ref ve out aynı mantıkta çalışmasına rağmen 
            //bir farkları vardır ki o da sudur outta number1 ın bir değeri olması gerekmez!!out ile gönderilen değerin method içinde tekrardan set edilmesi gerekir.


        }
        //METHOD OVERLOADING
        static int Multiply(int number1, int number2)
        {
            return number1* number2;
        }
        static int Multiply(int number1, int number2, int number3) 
        {
            return number1* number2* number3;
        }
        static int Add4(int number1, int number2) 
        {
            return number1 + number2;

        }
        static int Add5( params int[] numbers)
        {
            return numbers.Sum();   
        }

    }   
    
       

}