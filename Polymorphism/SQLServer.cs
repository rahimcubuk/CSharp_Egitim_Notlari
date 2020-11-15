using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class SQLServer : ICustomerDAL
    {
        public void Add()
        {
            Console.WriteLine("Added to SQL");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted to SQL");
        }

        public void Update()
        {
            Console.WriteLine("Updated to SQL");
        }
    }
}
