using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        Musteri[] musteriler = new Musteri[] { };
        public void Add(Musteri musteri,int musteriId,string musteriAd,string musteriSoyad)
        {
            musteri.Id = musteriId;
            musteri.Ad = musteriAd;
            musteri.Soyad = musteriSoyad;
            musteriler=musteriler.Append(musteri).ToArray();
            Console.WriteLine(musteriAd+" "+musteriSoyad+" Added!!");
        }

        public void View()
        {
            foreach (Musteri m in musteriler)
            { 
                Console.WriteLine(m.Id+ "\n" + m.Ad+"\n"+m.Soyad);
                Console.WriteLine("------------------");
            }
            
        }
        public void Delete(int Id)
        {
            musteriler = musteriler.Where((source, index) => index != (Id-1)).ToArray();

            Console.WriteLine((Id) + "id'li müşteri kaldırılmıştır.");

        }
    }
}
