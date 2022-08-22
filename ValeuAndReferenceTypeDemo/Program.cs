using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValeuAndReferenceTypeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //uygulama ilk olarak bu main metodu içinde başlar.
            System.Int32 sayi = 0; //yukarda tanımlamasaydık böyle yazıcaktık.
            int sayi2 = 5;
            int rakam = sayi2 + 10;

            int c = new int(); //0 dır. new yeni adres demek bütün değişiklikleri böyle tanımlamak gerekr.



            int a = 5;
            int b = a;
            a = 10;

            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);


            int[] aArray = { 1, 2, 3 };
            int[] bArray = aArray;
            int[] cArray = new int[3]; //burda kendi adresi oluşur atamalarda etkilenmez.

            aArray[0] = 10;
            bArray[1] = 20;
            cArray[2] = 100;



            aArray[0] = 10;
            Console.WriteLine("aArray=" + aArray.ToString()); //override olduğu için işe yaramaz
            Console.WriteLine("bArray=" + bArray.ToString());

            Console.WriteLine("aArray=" + string.Join("," ,aArray));
            Console.WriteLine("bArray=" + string.Join(",", bArray));
            //burada a ve b arrayleri eşit gelecektir heapte tutulduğu için (adresi tutuyor aslında adresteki değişikliği getiriyor)

            Console.WriteLine("bArray=" + string.Join(",", cArray));






            Console.ReadLine();




        }
    }
}
