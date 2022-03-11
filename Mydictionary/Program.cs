using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mydictionary
{
    internal class Program
    {

        static void Main(string[] args)
        {
            MyDictionary<int,string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Ahmet");
            myDictionary.Add(2, "Arzu");
<<<<<<< HEAD
            Console.WriteLine(myDictionary.ToString());
            Console.ReadLine();
=======
            myDictionary.Yazdır();
            Console.Read();
>>>>>>> 41e33b4da9f4a75a75505ce90c79deca2b85b6e8
        }
    }
}
