using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1=new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Yalçın";
            musteri1.Soyadi = "Uzun";
            musteri1.TcNo = "1234567890";
            TuzelMusteri musteri2=new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "123456";
                musteri2.SirketAdi = "Gehbili";
            musteri2.VergiNo = "12345678";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            MusteriManager musteriManager=new   MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.Add(musteri4);



        }
    }
}
