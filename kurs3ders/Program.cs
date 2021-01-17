using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs3ders
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";




            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1,urun2};

            foreach(Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------------");
                
            }
            Console.WriteLine("-------------Metotlar-------------");
            //instance-örnek
            //encapsulation
            sepetManager SepetManager = new sepetManager();
            SepetManager.Ekle(urun1);
            SepetManager.Ekle(urun2);
           
            SepetManager.Ekle2("Armut" ,"Yeşil" ,12,5);
            SepetManager.Ekle2("Elma", "Yeşil", 12,4);
            SepetManager.Ekle2("Karpuz", "Kırmızı", 12,2);

            Console.ReadKey();


        }
    }
}
