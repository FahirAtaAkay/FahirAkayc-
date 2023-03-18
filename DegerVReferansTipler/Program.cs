using System;

namespace DegerVReferansTipler 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("hello!!");

            int sayi1 = 10; //sayi 1 in değeri eşit 10 STACK DEGER TIP
            int sayi2 = 20;
            sayi1 = sayi2; //sayı 1 in değeri eşit sayı ikinin değeri sayı ikinin yalnızca değerini kopyaladık
            sayi2 = 65; //sonradan sayı iki değişti ama ilk kopyalanan değer değişmedi
            Console.WriteLine(sayi1); //sonuç 20 gözükür

            int[] sayilar1 = new int[] { 10,20,30 }; //Sayılar 1 stackte iken new dediğimizde heap bellekte yeni bir sayılar 1 verisi oluştu
            int[] sayilar2 = new int[] { 11, 12, 13 }; // sayılar 2 newlendiğinde heapte yeni bir adreste sayılar ikinin değerleri konumlandı
            // sayılar 1 eşit sayılar 2 dediğimizde heapteki adreslerini eşitlemiş olduk boylelikle sayılar 1 ve sayılar2 heapteki aynı adrese gitmis oldu
            sayilar1 = sayilar2; //kullanılmayan adres heap bellekten atılır.
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);
            //sonuc 999 program neden üsttekinden farklı
            //davrandı iste birinin değer birinin referans veri tipi olmasından kaynaklı
            //int double bool flood decimal bunlar birer değer tip
            // array calss interface ise referans tip stack n heap ust taraf stack 




        }
    }
}