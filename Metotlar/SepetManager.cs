using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention E nin büyük yazılması 
        //syntax
        public void Ekle(Product urun)
        {
            Console.WriteLine("Tebrikler Sepete eklendi:"+urun.Adi);
        }
        
        
        //Bu şekilde kullanılması kullanışlı değildir,ekstra bir parametre belirtildiğinde tüm kullanımlara da eklenmesi gerekir
        public void Ekle2(string urunAdi,string aciklama,double fiyat,int stok)
        {
            Console.WriteLine("Tebrikler Sepete eklendi:" + urunAdi);
        }
    }
}
