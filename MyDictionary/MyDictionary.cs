using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
     class MyDictionary<T,F>
    {
        T[] keys;
        F[] values;
        int count;

        public MyDictionary() 
        {
            keys = new T[0];
            values = new F[0];
            count  = 0;
        }
        public void Add(T key, F value) 
        {
            T[] tempArray = keys;
            keys = new T[keys.Length+1];
            F[] tempFArray = values;
            values = new F[tempArray.Length+1];
            count = 0;

            for (int i = 0; i < tempArray.Length; i++)

            {
                keys[i] = tempArray[i];
                values[i] = tempFArray[i];
                count++;

            }
            keys[count] = key;
            values[count] = value;
            count++;
        }
        public F search(T key) 
        {
            for (int i = 0;i < keys.Length;i++) 
            {
                if  (keys[i].Equals(key))// == referans tiplerin bellek konumunu  
                {
                    return values[i];//karsılastırırken equals metodu değer eşitliğini karsılastırır.
                }
            }

            return default(F);
            

        }

        

        public int Count 
        {
            get { return keys.Length; }
        }
        public T[] GetKeys
        {
            get { return keys; } 
        }
        public F[] GetFValues 
        {
            get { return values; }  
        }

    }
}
