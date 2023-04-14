using System;
using System.Collections.Generic;


namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Names = new string[] { "ali", "veli", "ahmet", "mehmet" };

            //Console.WriteLine(Names[0]);
            //Console.WriteLine(Names[1]);
            //Console.WriteLine(Names[2]);
            //Console.WriteLine(Names[3]);
            //Names = new string[5];
            //Names[4] = "ilker";
            //Console.WriteLine(Names[4]);
            //Console.WriteLine(Names[0]);
            //gelmez çünkü new dediğim andaheapte yeni bir adres verdim
            List<string> Names2 = new List<string>() { "ali", "nazlı", "ahmet", "mehmet" };
            Console.WriteLine(Names2[0]);
            Console.WriteLine(Names2[1]);
            Console.WriteLine(Names2[2]);
            Console.WriteLine(Names2[3]);
            Names2.Add("merve");
            Console.WriteLine(Names2[4]);
            Console.WriteLine(Names2[0]);

        }


    }
}


