using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            
            IKrediManager tasitKrediManager = new TasitKrediManager();
            

            IKrediManager konutKrediManager = new KonutKrediManager();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager =new BasvuruManager();
            basvuruManager.Basvuruyap(ihtiyacKrediManager,databaseLoggerService);
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,konutKrediManager};
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            Console.Read();
        }
    }
}
