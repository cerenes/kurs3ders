using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ??  30
            //int,decimal,float,double,bool= değer tip


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayialr1[0]??   999
            // array, class interface= referans tip

            //bellekte stock ve heap adında iki yer vardır.değer tip stockda gerçekleşir.
            //new demek heap bellekte bir adres oluştur
        }
    }
}
