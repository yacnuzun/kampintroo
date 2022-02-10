using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //add();
            //int number1 ;
            //int number2 = 20;
            //var result=add2(out number1,number2);
            //Console.WriteLine(result);
            //Console.WriteLine(Multiply(2, 4));
            //Console.WriteLine(Multiply(2, 4,6));
            Console.WriteLine(add4(1, 2, 3, 4, 9, 10));
            Console.ReadLine();
        }
        static void add()
        {
            Console.WriteLine("Added!!");
        }
        static int add2(out int number1, int number2=30)
        {
            number1 = 40;
            return number1 + number2;
        }
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2*number3;
        }
        static int add4(params int [] numbers)
        {
            return numbers.Sum();
        }
    }
}
