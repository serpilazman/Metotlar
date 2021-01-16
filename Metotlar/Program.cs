using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";


            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 45;
            urun2.Aciklama = "Diyarbakır karpuzu";


            //cw tab tab --> Console.WriteLine();
            //Dizi şeklinde,veriler veri kaynağından gelir-API,veritabanı,excel

            Product[] urunler = new Product[] {urun1,urun2 };

            //type-safe--tip güvenliği--Product yerine var da yazılabilir

            foreach (Product item in urunler)
            {
                Console.WriteLine(item.Adi);
                Console.WriteLine(item.Fiyati);
                Console.WriteLine(item.Aciklama);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("----------Metotlar---------");

            SepetManager sepetManager = new SepetManager();

            //Encapsulation a uygun bir metot kullanımı Ekle metodu
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut" ,"Yeşil armut", 12);
            sepetManager.Ekle2("Elma", "Kırmızı elma", 13);
            sepetManager.Ekle2("Karpuz", "Adana Karpuzu", 14);



        }
    }
}
