using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
            new Worker(),
            new Robot()
            };
            foreach (var worker in workers)
            {
                Console.WriteLine(worker);
            }
            ISalary[] getSalarys = new ISalary[2]
            {
                new Manager(),
                new Worker()
            };
            foreach(var getSalary in getSalarys)
            {
                Console.WriteLine(getSalary);
            }
            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };
            foreach (var eat in eats)
            {
                Console.WriteLine(eat);
            }
        }
    }
    interface IWorker
    {
        void Work();

    }
    interface IEat
    {

        void Eat();

    }
    interface ISalary
    {
        void GetSalary();

    }
    class Worker : IWorker, ISalary, IEat
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Manager : IWorker, ISalary, IEat
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
