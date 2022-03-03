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
            Console.WriteLine(myDictionary.ToString());
        }
    }
}
