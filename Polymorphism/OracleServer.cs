using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class OracleServer : ICustomerDAL
    {
        public void Add()
        {
            Console.WriteLine("Added to Oracle");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted to Oracle");
        }

        public void Update()
        {
            Console.WriteLine("Updated to Oracle");
        }
    }
}
