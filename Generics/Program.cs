using System;
using System.Collections.Generic;

namespace Generics 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            List<string> Cities = new List<string>();
            
             Cities.Add("ANKARA");
           Console.WriteLine(Cities.Count);
            MyList<string> Cities2 = new MyList<string>();
            Cities2.Add("ANKARA");
            Console.WriteLine(Cities2.Count);

        }
    }
    class MyList<T>//artık bir generic classımız var
    {
        T[] array;
        T[] tempArray;
        public MyList()
        {
            array = new T[0];
            
        }
        public void Add(T item)
        {
            tempArray = array;

            array = new T[array.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                array[i] = tempArray[i];
            }
            array[array.Length-1] = item;

        }
        public int Count 
        {
            get { return array.Length; }






        }


    }

}
