using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.Add();
            //customerManager.Update();
            //Console.Read();
            Customer customer = new Customer();
            customer.Id = 1;
            customer.City = "Ankara";
            customer.FirstName = "Yalçın";
            customer.LstName = "Uzun";
            Customer customer2=new Customer() { Id = 2 ,City="İstanbul",FirstName="Miktad",LstName="Gürsel"};
            Console.WriteLine(customer2.FirstName);
            Console.Read();
        }
    }
    class Customer
    {
        public int  Id { get; set; }
        private string _firstName { get; set; }
        public string FirstName {
            get
            {
                return "Mr." + _firstName;
            }
            set {  _firstName=value; } }

        public string LstName{ get; set; }

        public string City{ get; set; }

    }
    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added!");
        }
        public void Update()
        {
            Console.WriteLine("Customer Update!!");
        }
    }
}
