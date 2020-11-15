using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager("Rahim", "Manisa");
            customerManager.Add();

            EmployeerManager.List("Rahim", "Manisa");

            Console.ReadKey();
        }

        class CustomerManager
        {
            private int _count = 10;
            private string _name;
            private string _city;
            
            public CustomerManager() { }
            public CustomerManager(int count) { _count = count; }

            public CustomerManager(string name, string city)
            {
                _name = name;
                _city = city;
            }

            public void List()
            {
                Console.WriteLine("Listed!!'");
            }

            public void Add()
            {
                Console.WriteLine("nonStatic - {0}'lı {1}.",_city,_name);
            }
        }

        static class EmployeerManager
        {
            public static void List(string name, string city)
            {
                Console.WriteLine("Static - {0}'lı {1}.", city, name);
            }
        }
    }
}
