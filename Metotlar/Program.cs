using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Aciklama = "";
            urun1.Fiyati = 10;
            urun1.StokAdedi = 100;

            Urun urun2 = new Urun();
            urun2.Adi = "Armut";
            urun2.Aciklama = "";
            urun2.Fiyati = 10;
            urun2.StokAdedi = 100;

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            Console.ReadLine();  

        }
    }
}
